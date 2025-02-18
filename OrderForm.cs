using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace yacht_yard_practic
{
    public partial class OrderForm : Form
    {
        public OrderForm()
        {
            InitializeComponent();
            addPartners();
            this.checkedListBox1.HorizontalScrollbar = true;
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

        private void TreeView1_BeforeCheck(object sender, TreeViewCancelEventArgs e)
        {
            TreeView _treeView = sender as TreeView;
            // Временно отключаем обработчик события
            _treeView.BeforeCheck -= TreeView1_BeforeCheck;

            try
            {
                // Снимаем отметку со всех остальных элементов
                for (int i = 0; i < _treeView.Nodes.Count; i++)
                {
                    if (_treeView.Nodes[i].Level == 0) // Снимать отметку с корневых элементов 
                    {
                        _treeView.Nodes[i].Checked = false;
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
            finally
            {
                // Восстанавливаем обработчик события в любом случае
                _treeView.BeforeCheck += TreeView1_BeforeCheck;
            }
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

            // Обновляем панель после изменения
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

            if (selectedItem == null) return;

            // Создаем новый список
            CheckedListBox newList = new CheckedListBox();
            newList.Dock = DockStyle.Fill;

            // Добавляем элементы в зависимости от выбранного элемента
            newList.Items.AddRange(GetItemsForEquipment(selectedItem.ToString()));

            addEquipPanel.Controls.Add(newList);
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
                    return new[] { "Черпак", "Весла", "Навес", "Зонтик", "Спасательный жилет" };
                case "Модели эконом класса":
                    return new[] { "Чек (платный)" };
                case "Модели класса Люкс":
                    return new[] { "Черпак", "Весла", "Навес", "Зонтик", "Спасательный жилет",
                        "Холодильник", "Бассейн", "Выдвижной пирс", "Бар"};
                case "Стандартная комплектация":
                    return new[] { "Черпак", "Весла", "Спасательный жилет" };
                default:
                    return Array.Empty<string>();
            }
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
        }

        // пока пустой метод
        private void startOrderButton_Click(object sender, EventArgs e)
        {

        }
    }
}
