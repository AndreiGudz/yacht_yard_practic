using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace yacht_yard_practic
{
    public partial class OrderForm : Form
    {
        bool canMakeOrder = true;
        int machtCount = 0;
        int price = 100;
        string model = string.Empty;
        string material = string.Empty;
        public List<string> boatColor = new List<string>();
        public List<string> boatAddEquip = new List<string>();
        public OrderForm()
        {
            InitializeComponent();
            addPartners();

            foreach (TreeNode rootNode in treeView1.Nodes)
            {
                // Раскрываем все дочерние элементы
                rootNode.ExpandAll();
            }
        }

        void addPartners()
        {
            string str = """
                ООО «Доски»
                ООО «Краски»
                ЗАО "Плавание»
                ООО "Верфь"
                ООО "Чемпионы"
                ООО "Русалка"
                """;
            var partners = str.Split('\n');

            foreach (var partner in partners)
            {
                System.Windows.Forms.Label partnerLabel = new System.Windows.Forms.Label();
                partnerLabel.Text = partner;
                partnerLabel.AutoSize = true; // Изменить размер Label согласно тексту
                flowLayoutPanel1.Controls.Add(partnerLabel);
            }
        }

        private void OrderForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void treeView1_AfterCheck(object sender, TreeViewEventArgs e)
        {
            TreeView _treeView = sender as TreeView;
            // Временно отключаем обработчик события
            _treeView.AfterCheck -= treeView1_AfterCheck;

            try
            {
                // Снимаем отметку со всех корневых элементов
                foreach (var item in _treeView.Nodes)
                    (item as TreeNode).Checked = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
            finally
            {
                // Восстанавливаем обработчик события в любом случае
                _treeView.AfterCheck += treeView1_AfterCheck;
            }
            if (e.Node is not null)
                if (e.Node.Checked && e.Node.Parent is not null)
                    boatColor.Add(e.Node.Text);
                else
                    boatColor.Remove(e.Node.Text);

            OrderListBoxFill();
        }

        private void CheckedListBox_OneItemCheck(object sender, ItemCheckEventArgs e)
        {
            CheckedListBox clb = sender as CheckedListBox;
            if (clb == null) return;

            clb.ItemCheck -= CheckedListBox_OneItemCheck;

            // Запрещаем снятие последнего выбранного элемента
            if (e.NewValue == CheckState.Unchecked && clb.CheckedItems.Count == 1)
            {
                e.NewValue = CheckState.Checked;
            }
            else if (e.NewValue == CheckState.Checked)
            {
                // Снимаем выделение с других элементов
                for (int i = 0; i < clb.Items.Count; i++)
                {
                    if (i != e.Index) clb.SetItemChecked(i, false);
                }
            }

            clb.ItemCheck += CheckedListBox_OneItemCheck;

            clb.BeginInvoke(
                new Action(() =>
                {
                    UpdateAddEquipPanel(clb.CheckedItems.Count > 0 ? clb.CheckedItems[0] : null);
                }
                    )
                );
        }

        private void UpdateAddEquipPanel(object selectedItem)
        {
            // Удаляем старый список
            foreach (Control ctrl in addEquipPanel.Controls.OfType<CheckedListBox>().ToList())
            {
                addEquipPanel.Controls.Remove(ctrl);
                ctrl.Dispose();
            }
            boatAddEquip.Clear();

            if (selectedItem == null) return;

            // Создаем новый список
            CheckedListBox newList = new CheckedListBox();
            newList.Dock = DockStyle.Fill;
            newList.Font = new System.Drawing.Font("Arial Narrow", 14.1428576F);
            newList.HorizontalScrollbar = true;
            newList.ItemCheck += AddEquipCLB_ItemCheck;

            // Добавляем элементы в зависимости от выбранного элемента
            newList.Items.AddRange(GetItemsForEquipment(selectedItem.ToString()));

            addEquipPanel.Controls.Add(newList);

            boatAddEquip.Clear();
            model = selectedItem.ToString();
            OrderListBoxFill();
        }

        private string[] GetItemsForEquipment(string equipment)
        {
            /*
            Стандартные модели
            Модели эконом класса
            Модели класса Люкс
            Стандартная комплектация
             */
            switch (equipment)
            {
                case "Стандартные модели":
                    price = 200;
                    machtCount = 1;
                    return new[]
                    {
                        "Черпак", "Весла", "Навес", "Зонтик",
                        "Спасательный жилет", "Дополнительная мачта"
                    };
                case "Модели эконом класса":
                    price = 10;
                    machtCount = 0;
                    return new[]
                    {
                        "Напутствие (бесплатно)"
                    };
                case "Модели класса Люкс":
                    price = 1000;
                    machtCount = 3;
                    return new[]
                    {
                        "Черпак", "Весла", "Навес", "Зонтик",
                        "Спасательный жилет", "Холодильник", "Бассейн",
                        "Выдвижной пирс", "Бар", "Дополнительная мачта"
                    };
                case "Стандартная комплектация":
                    price = 300;
                    machtCount = 1;
                    return new[]
                    {
                        "Черпак", "Весла", "Спасательный жилет", "Дополнительная мачта"
                    };
                default:
                    return Array.Empty<string>();
            }
        }

        private void AddEquipCLB_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            CheckedListBox clb = sender as CheckedListBox;
            if (clb == null) return;

            if (e.NewValue == CheckState.Checked)
                boatAddEquip.Add(clb.GetItemText(clb.Items[e.Index]));
            else
                boatAddEquip.Remove(clb.GetItemText(clb.Items[e.Index]));

            OrderListBoxFill();
        }

        private void checkedListBox2_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            CheckedListBox clb = sender as CheckedListBox;
            if (clb == null) return;

            clb.ItemCheck -= checkedListBox2_ItemCheck;

            // Запрещаем снятие последнего выбранного элемента
            if (e.NewValue == CheckState.Unchecked && clb.CheckedItems.Count == 1)
            {
                e.NewValue = CheckState.Checked;
            }
            else if (e.NewValue == CheckState.Checked)
            {
                // Снимаем выделение с других элементов
                for (int i = 0; i < clb.Items.Count; i++)
                {
                    if (i != e.Index) clb.SetItemChecked(i, false);
                }
            }

            clb.ItemCheck += checkedListBox2_ItemCheck;

            material = clb.GetItemText(clb.Items[e.Index]);
            OrderListBoxFill();
        }

        private void startOrderButton_Click(object sender, EventArgs e)
        {
            CheckedListBox? addEquipCLP = addEquipPanel.Controls.OfType<CheckedListBox>().FirstOrDefault();
            if (checkedListBox1.CheckedItems.Count == 0)
            {
                MessageBox.Show("Выберите модель", "предупреждение");
                return;
            }
            if (checkedListBox2.CheckedItems.Count == 0)
            {
                MessageBox.Show("Выберите материал", "предупреждение");
                return;
            }

            if (addEquipCLP is not null && canMakeOrder)
            {
                var result = MessageBox.Show(
                        "Начав заказ, вы не сможете от него отказаться\n\r" +
                        "Вы хотите продолжить?",
                        "Сообщение",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Information,
                        MessageBoxDefaultButton.Button1
                    );
                if (result == DialogResult.Yes)
                { 
                    StartOrder();
                    this.Focus();
                }
            }
        }

        private void StartOrder()
        {
            canMakeOrder = false;
            startOrderButton.Enabled = false;
            startOrderButton.Text = "Заказ выполняется";

            StatusTextBox.Text = "Статус заказа\r\nНачато производство";

            OrderListBoxFill();
        }

        void OrderListBoxFill()
        {
            OrderlistBox.Items.Clear();
            OrderlistBox.Items.Add("Модель: ");
            OrderlistBox.Items.Add($" - {model}");

            OrderlistBox.Items.Add("Цвета: ");
            if (boatColor.Count() == 0)
                OrderlistBox.Items.Add($" - Цвет древесины");
            else
                foreach (var color in boatColor)
                    OrderlistBox.Items.Add($" - {color}");

            OrderlistBox.Items.Add("Материал: ");
            OrderlistBox.Items.Add($" - {material}");

            OrderlistBox.Items.Add("Дополнительное оборудование:");
            foreach (var equip in boatAddEquip)
                OrderlistBox.Items.Add($" - {equip}");

            OrderlistBox.Items.Add("Гарантия: 25 лет");
            OrderlistBox.Items.Add($"Количество мачт: {machtCount}");
            OrderlistBox.Items.Add("Базовая цена: ");
            OrderlistBox.Items.Add($"{price} - без дополнительных аксессуаров и комплектующих");
        }
    }
}
