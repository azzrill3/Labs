using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace WindowsFormsApp5
{
    public partial class Form1 : Form
    {
        private DataStorage data;

        public Form1()
        {
            InitializeComponent();
        }

        private void buttonLoad_Click(object sender, EventArgs e)
        {
            openFileDialog.InitialDirectory = Application.StartupPath;
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                ShowData(openFileDialog.FileName);
            }
        }
        public void ShowData(string datapath)
        {
            try
            {
                data = DataStorage.DataCreator(datapath);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Что-то пошло не так");
            }
            
            dataGridViewIn.DataSource = data.GetRawData();
            dataGridViewIn.ReadOnly = true;
            dataGridViewOut.DataSource = data.GetSummaryData();
            dataGridViewOut.ReadOnly = true;
        }
    }
    class RawDataItem
    {
        public string Name { get; set; }
        public int Rooms { get; set; }
        public int Meters { get; set; }
        public int Price { get; set; }
        public double MeterPrice { get { return Price / Meters; } }
    }

    class SummaryDataItem
    {
        public string Name { get; set; }
        public int Summary { get; set; }
    }

    interface DataInterface
    {
        List<RawDataItem> GetRawData { get; set; }
        List<SummaryDataItem> GetSummaryData { get; set; }
    }

    class DataStorage : DataInterface
    {
        public bool IsReady
        {
            get
            {
                if (rawdata == null) return false;
                else return true;
            }
        }

        List<RawDataItem> DataInterface.GetRawData { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        List<SummaryDataItem> DataInterface.GetSummaryData { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        private List<RawDataItem> rawdata;
        private List<SummaryDataItem> sumdata;
        private char devider = '*';
        private DataStorage() { }
        private void BuildSummary()
        {
            int[] HouseSum = new int[3];
            foreach (RawDataItem item in rawdata)
            {
                if (item.Name == "Дом") HouseSum[0] += item.Price;
                if (item.Name == "Квартира") HouseSum[1] += item.Price;
                if (item.Name == "Комната") HouseSum[2] += item.Price;
            }

            sumdata = new List<SummaryDataItem>();
            for (int i = 0; i < 3; i++)
            {
                string name = "";
                if (i == 0) name = "Дома";
                else if (i == 1) name = "Квартиры";
                else name = "Комнаты";
                sumdata.Add(new SummaryDataItem()
                {
                    Name = name,
                    Summary = HouseSum[i]
                });
            }
        }
        public bool InitData(string datapath)
        {
            rawdata = new List<RawDataItem>();

            try
            {
                StreamReader sr = new StreamReader(datapath, Encoding.UTF8);
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    string[] split = line.Split(devider);
                    var item = new RawDataItem()
                    {
                        Name = split[0].Trim(),
                        Rooms = Convert.ToInt32(split[1].Trim()),
                        Meters = Convert.ToInt32(split[2].Trim()),
                        Price = Convert.ToInt32(split[3].Trim())
                    };
                    rawdata.Add(item);
                }
                sr.Close();
                BuildSummary();
            }
            catch (Exception ex)
            {
                return false;
            }
            return true;
        }
        public static DataStorage DataCreator(string path)
        {
            DataStorage storage = new DataStorage();
            if (storage.InitData(path))
                return storage;
            else
                return null;
        }

        public List<RawDataItem> GetRawData()
        {
            if (this.IsReady)
                return rawdata;
            else
                return null;
        }

        public List<SummaryDataItem> GetSummaryData()
        {
            if (this.IsReady)
                return sumdata;
            else
                return null;
        }
    }
}
