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
        int basePrice = 0;
        int rowersCount = 0;
        string model = string.Empty;
        string material = string.Empty;
        public List<string> boatColor = new List<string>();
        public List<string> boatAddEquip = new List<string>();
        int orderNumber = 1;

        public OrderForm()
        {
            InitializeComponent();
            addPartners();
            orderNumLabel.Text += orderNumber.ToString("D5");


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

            OneItemCheck(clb, CheckedListBox_OneItemCheck, e);

            clb.BeginInvoke(
                new Action(() => {UpdatePanels(clb.CheckedItems.Count > 0 ? clb.CheckedItems[0] : null);})
                );
        }

        private void UpdatePanels(object selectedItem)
        {
            // Удаляем старый список моделей
            foreach (Control ctrl in modelPanel.Controls.OfType<CheckedListBox>().ToList())
            {
                modelPanel.Controls.Remove(ctrl);
                ctrl.Dispose();
            }
            model = string.Empty;

            // Удаляем старый список дополнений
            foreach (Control ctrl in addEquipPanel.Controls.OfType<CheckedListBox>().ToList())
            {
                addEquipPanel.Controls.Remove(ctrl);
                ctrl.Dispose();
            }
            boatAddEquip.Clear();

            if (selectedItem == null) return;

            // Создаем новый список дополнений
            CheckedListBox newAddEquipList = new CheckedListBox();
            newAddEquipList.Dock = DockStyle.Fill;
            newAddEquipList.Font = new System.Drawing.Font("Arial Narrow", 14.1428576F);
            newAddEquipList.HorizontalScrollbar = true;
            newAddEquipList.ItemCheck += AddEquipCLB_ItemCheck;

            // Добавляем элементы в зависимости от выбранного элемента
            newAddEquipList.Items.AddRange(GetItemsForEquipment(selectedItem.ToString()));

            addEquipPanel.Controls.Add(newAddEquipList);

            // Создаем новый список моделей
            CheckedListBox newModelList = new CheckedListBox();
            newModelList.Dock = DockStyle.Fill;
            newModelList.Font = new System.Drawing.Font("Arial Narrow", 14.1428576F);
            newModelList.HorizontalScrollbar = true;
            newModelList.ItemCheck += ModelCLB_ItemCheck;

            // Добавляем элементы в зависимости от выбранного элемента
            newModelList.Items.AddRange(GetItemsForModel(selectedItem.ToString()));

            modelPanel.Controls.Add(newModelList);


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
                    return new[]
                    {
                        "Черпак", "Весла", "Навес", "Зонтик",
                        "Спасательный жилет", "Дополнительная мачта"
                    };
                case "Модели эконом класса":
                    return new[]
                    {
                        "Напутствие (бесплатно)"
                    };
                case "Модели класса Люкс":
                    return new[]
                    {
                        "Черпак", "Весла", "Навес", "Зонтик",
                        "Спасательный жилет", "Холодильник", "Бассейн",
                        "Выдвижной пирс", "Бар", "Дополнительная мачта"
                    };
                case "Стандартная комплектация":
                    return new[]
                    {
                        "Черпак", "Весла", "Спасательный жилет", "Дополнительная мачта"
                    };
                default:
                    return Array.Empty<string>();
            }
        }
        private string[] GetItemsForModel(string model)
        {
            /*
            Стандартные модели
            Модели эконом класса
            Модели класса Люкс
            Стандартная комплектация
             */
            switch (model)
            {
                case "Стандартные модели":
                    basePrice = 200;
                    machtCount = 1;
                    return new[]
                    {
                        "парусная лодка"
                    };
                case "Модели эконом класса":
                    basePrice = 10;
                    machtCount = 0;
                    return new[]
                    {
                        "шлюпка"
                    };
                case "Модели класса Люкс":
                    basePrice = 1000;
                    machtCount = 3;
                    return new[]
                    {
                        "галера"
                    };
                case "Стандартная комплектация":
                    basePrice = 300;
                    machtCount = 1;
                    return new[]
                    {
                        "разрабатывается"
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

        private void ModelCLB_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            CheckedListBox clb = sender as CheckedListBox;
            if (clb == null) return;

            OneItemCheck(clb, ModelCLB_ItemCheck, e);

            model = clb.Items[e.Index].ToString();
            OrderListBoxFill();
        }

        private void checkedListBox2_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            CheckedListBox clb = sender as CheckedListBox;
            if (clb == null) return;

            OneItemCheck(clb, checkedListBox2_ItemCheck, e);

            material = clb.GetItemText(clb.Items[e.Index]);
            OrderListBoxFill();
        }

        private void startOrderButton_Click(object sender, EventArgs e)
        {
            CheckedListBox? addEquipCLP = addEquipPanel.Controls.OfType<CheckedListBox>().FirstOrDefault();
            if (model == string.Empty)
            {
                MessageBox.Show("Выберите модель", "предупреждение");
                return;
            }
            if (model == "разрабатывается")
            {
                MessageBox.Show("Выберите существующую модель", "предупреждение");
                return;
            }
            if (material == string.Empty)
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
            StatusTextBox.BackColor = Color.LightCyan;

            OrderListBoxFill();
        }

        void OrderListBoxFill()
        {
            OrderlistBox.Items.Clear();
            OrderlistBox.Items.Add(orderNumLabel.Text);
            OrderlistBox.Items.Add("Заказ на деревянную яхту");
            OrderlistBox.Items.Add("Модель: ");
            OrderlistBox.Items.Add($" - {model}");

            OrderlistBox.Items.Add($"Количество мест для гребцов: {rowersCount}");

            OrderlistBox.Items.Add("Материал: ");
            OrderlistBox.Items.Add($" - {material}");

            OrderlistBox.Items.Add("Цвета: ");
            if (boatColor.Count() == 0)
                OrderlistBox.Items.Add($" - Цвет древесины");
            else
                foreach (var color in boatColor)
                    OrderlistBox.Items.Add($" - {color}");

            OrderlistBox.Items.Add($"Количество мачт: {machtCount}");

            OrderlistBox.Items.Add("Гарантия: 25 лет");
            OrderlistBox.Items.Add("Транспортировка:");
            OrderlistBox.Items.Add("   Вся продукция продается только на условиях доставки за счет клиента.");
            OrderlistBox.Items.Add("   Клиенты несут ответственность за перевозку");
            
            OrderlistBox.Items.Add("Базовая цена: ");
            OrderlistBox.Items.Add($"{basePrice} - без дополнительных аксессуаров и комплектующих");

            OrderlistBox.Items.Add("Дополнительное оборудование:");
            foreach (var equip in boatAddEquip)
                OrderlistBox.Items.Add($" - {equip}");
        }

        void OneItemCheck(CheckedListBox clb, ItemCheckEventHandler eventHandler, ItemCheckEventArgs e)
        {
            clb.ItemCheck -= eventHandler;

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

            clb.ItemCheck += eventHandler;
        }
    }
}
