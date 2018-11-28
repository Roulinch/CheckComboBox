using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CheckComboBox
{
    public partial class CheckComboBox : UserControl
    {
        //-----------------------Private------------------------------
        TextBox _textBox;
        CheckedListBox _checkedList;
        bool _dropped;
        CheckComboBoxTextMode _textMode;
        List<String> _checkedItems;
        String _placeholderText;

        //----------------------Public--------------------------------
        public TextBox TextBox { get => _textBox; }
        public CheckedListBox CheckedList { get => _checkedList; }
        public bool Droped { get => _dropped; }
        public CheckComboBoxTextMode TextMode { get => _textMode; set => _textMode = value; }
        public List<string> CheckedItems { get => _checkedItems; }
        public string PlaceholderText { get => _placeholderText; set => _placeholderText = value; }


        /// <summary>
        /// Create a new instance of the <see cref="CheckComboBox"/> class
        /// </summary>
        public CheckComboBox()
        {
            InitializeComponent();

            _dropped = false;
            _textMode = CheckComboBoxTextMode.Items;

            _checkedItems = new List<string>();
            _placeholderText = "A placeholder text";

            _textBox = ttbMain;
            _checkedList = InitializeCheckList();

            ttbMain.Text = _placeholderText;
        }


        /// <summary>
        /// Allow to add string items to checked list
        /// </summary>
        /// <param name="Items"></param>
        public void SetItems(List<String> Items)
        {
            ListBox.ObjectCollection temp = new ListBox.ObjectCollection(_checkedList);

            foreach (String item in Items)
            {
                temp.Add(item);
            }

            _checkedList.Items.AddRange(temp);
        }


        /// <summary>
        /// Create the checked list
        /// </summary>
        /// <returns></returns>
        private CheckedListBox InitializeCheckList()
        {
            CheckedListBox checkedList = new CheckedListBox();

            checkedList.Width = this.Width;
            checkedList.Height = 100;
            checkedList.IntegralHeight = true;
            checkedList.Visible = false;
            checkedList.Location = new Point(0, ttbMain.Height);
            checkedList.CheckOnClick = true;
            checkedList.ItemCheck += new ItemCheckEventHandler(OnItemCheckChange);
            this.Controls.Add(checkedList);

            return checkedList;
        }


        /// <summary>
        /// When user click on arrow button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDropDown_Click(object sender, EventArgs e)
        {
            if (_dropped)
                DropUp();
            else
                DropDown();
        }


        /// <summary>
        /// When user click on textbox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ttbMain_Click(object sender, EventArgs e)
        {
            //CheckListDropDown(ttbMain, null);

            if (_dropped)
                DropUp();
            else
                DropDown();
        }


        /// <summary>
        /// Drop the checked list down
        /// </summary>
        public void DropDown()
        {
            if (_dropped)
                return;

            _dropped = true;

            _checkedList.Visible = true;
            this.Height += _checkedList.Height;

            btnDropDown.Text = "▲";
        }


        /// <summary>
        /// Drop the checked list Up
        /// </summary>
        public void DropUp()
        {
            if (!_dropped)
                return;

            _dropped = false;

            _checkedList.Visible = false;
            this.Height -= _checkedList.Height;

            btnDropDown.Text = "▼";
        }


        /// <summary>
        /// When an item change check state
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public virtual void OnItemCheckChange(object sender, ItemCheckEventArgs e)
        {
            //_checkedItems = new List<string>();
            Int32 Count = _checkedList.CheckedItems.Count;
            if (e.NewValue == CheckState.Checked)
            {
                _checkedItems.Add(CheckedList.Items[e.Index].ToString());
                Count++;
            } 

            if (e.NewValue == CheckState.Unchecked)
            {
                _checkedItems.Remove(CheckedList.Items[e.Index].ToString());
                Count--;
            }

            switch (TextMode)
            {
                case CheckComboBoxTextMode.NumberOfItems:
                    ttbMain.Text = Count + " items";
                    break;

                case CheckComboBoxTextMode.Items:
                    StringBuilder builder = new StringBuilder();
                    foreach (string item in CheckedItems.OrderBy(x => x))
                    {
                        builder.Append("'" + item + "', ");
                    }

                    if (Count != 0 || builder.ToString().Length != 0)
                        ttbMain.Text = builder.ToString().Remove(builder.ToString().Length - 2, 2);
                    else
                        ttbMain.Text = PlaceholderText;

                    break;

                default:
                    ttbMain.Text = "Error ...";
                    break;
            }
        }  
    }

    public enum CheckComboBoxTextMode
    {
        NumberOfItems,
        Items
    }
}
