using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practice_v3
{
    public partial class SimulationForm : Form
    {
        public SimulationForm(List<RegStorage> regStorages)
        {
            InitializeComponent();
            _regStorages = regStorages;
            UpdateValues();
        }

        public List<RegStorage> _regStorages = new List<RegStorage>();
        private bool allStoragesEmpty = false;
        private bool isRunning = false;
        private int dayCounter = 0;

        private async void Start_BTN_Click(object sender, EventArgs e)
        {
            isRunning = true;

            while (isRunning && !allStoragesEmpty)
            {
                foreach(var storage in _regStorages)
                {
                    if (storage._isConsumable)
                    {
                        storage.DecreaseRandom();
                    }

                    if(storage._currentValue == 0)
                    {
                        RefillStorage(storage._id, storage._supplyID);
                    }
                }
                allStoragesEmpty = CheckEmpty();
                UpdateValues();
                Counter_TB.Text = (++dayCounter).ToString();
                await Task.Delay(500);
            }
        }

        private void UpdateValues()
        {
            LB_ST_1.Text = _regStorages[0]._currentValue.ToString();
            LB_ST_2.Text = _regStorages[1]._currentValue.ToString();
            LB_ST_3.Text = _regStorages[2]._currentValue.ToString();
            LB_ST_4.Text = _regStorages[3]._currentValue.ToString();
            LB_ST_5.Text = _regStorages[4]._currentValue.ToString();
            LB_ST_6.Text = _regStorages[5]._currentValue.ToString();
        }

        private bool CheckEmpty()
        {
            int sum = 0;
            foreach(var storage in _regStorages)
            {
                sum += storage._currentValue;
            }
            if (sum == 0)
                return true;
            else
                return false;
        }

        private void RefillStorage(int targetID, int supplyID)
        {
            if (supplyID != targetID)
            {
                if (_regStorages[supplyID]._currentValue >= _regStorages[targetID]._capacity)
                {
                    _regStorages[targetID].IncreaseValue(_regStorages[targetID]._capacity);
                    _regStorages[supplyID].DecreaseCount(_regStorages[targetID]._capacity);
                }
                else
                {
                    _regStorages[targetID].IncreaseValue(_regStorages[supplyID]._currentValue);
                    _regStorages[supplyID].DecreaseCount(_regStorages[supplyID]._currentValue);
                }
            }
        }

        private void Stop_BTN_Click(object sender, EventArgs e)
        {
            isRunning = false;
        }

        private void Graphic_BTN_Click(object sender, EventArgs e)
        {
            List<RegStorage> toGraphic = new List<RegStorage>();
            List<string> names = new List<string>();
            for(int i = 0; i<checkList.Items.Count; i++)
            {
                if (checkList.GetItemChecked(i))
                {
                    toGraphic.Add(_regStorages[i]);
                    names.Add("Склад " + (i + 1));
                }
            }

            GrapficForm grapfic = new GrapficForm(toGraphic, names);
            grapfic.Show();
        }

        private void SimulationForm_FormClosing(object sender, FormClosingEventArgs e)
        {

        }
    }
}
