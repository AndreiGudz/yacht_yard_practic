namespace yacht_yard_practic
{
    partial class OrderForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Коричневый");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Белый");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Чёрный");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Зелёный");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Красный");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Синий");
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("Стандартные", new System.Windows.Forms.TreeNode[] { treeNode1, treeNode2, treeNode3, treeNode4, treeNode5, treeNode6 });
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("Коралловый");
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("Индиго");
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("Шоколадный");
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("Бирюзовый");
            System.Windows.Forms.TreeNode treeNode12 = new System.Windows.Forms.TreeNode("Фуксия");
            System.Windows.Forms.TreeNode treeNode13 = new System.Windows.Forms.TreeNode("Другие цвета", new System.Windows.Forms.TreeNode[] { treeNode8, treeNode9, treeNode10, treeNode11, treeNode12 });
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrderForm));
            tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            checkedListBox2 = new System.Windows.Forms.CheckedListBox();
            label4 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            treeView1 = new System.Windows.Forms.TreeView();
            addEquipPanel = new System.Windows.Forms.Panel();
            flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            label5 = new System.Windows.Forms.Label();
            startOrderButton = new System.Windows.Forms.Button();
            OrderlistBox = new System.Windows.Forms.ListBox();
            StatusTextBox = new System.Windows.Forms.TextBox();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 1);
            tableLayoutPanel1.Controls.Add(flowLayoutPanel1, 0, 2);
            tableLayoutPanel1.Controls.Add(label5, 0, 0);
            tableLayoutPanel1.Controls.Add(startOrderButton, 1, 2);
            tableLayoutPanel1.Controls.Add(OrderlistBox, 1, 1);
            tableLayoutPanel1.Controls.Add(StatusTextBox, 1, 0);
            tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.01425F));
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 85.98575F));
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 75F));
            tableLayoutPanel1.Size = new System.Drawing.Size(788, 476);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 4;
            tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            tableLayoutPanel2.Controls.Add(checkedListBox2, 2, 1);
            tableLayoutPanel2.Controls.Add(label4, 3, 0);
            tableLayoutPanel2.Controls.Add(label3, 2, 0);
            tableLayoutPanel2.Controls.Add(label1, 1, 0);
            tableLayoutPanel2.Controls.Add(label2, 0, 0);
            tableLayoutPanel2.Controls.Add(checkedListBox1, 0, 1);
            tableLayoutPanel2.Controls.Add(treeView1, 1, 1);
            tableLayoutPanel2.Controls.Add(addEquipPanel, 3, 1);
            tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            tableLayoutPanel2.Location = new System.Drawing.Point(3, 59);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            tableLayoutPanel2.Size = new System.Drawing.Size(624, 338);
            tableLayoutPanel2.TabIndex = 1;
            // 
            // checkedListBox2
            // 
            checkedListBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            checkedListBox2.Font = new System.Drawing.Font("Arial Narrow", 14.1428576F);
            checkedListBox2.FormattingEnabled = true;
            checkedListBox2.HorizontalScrollbar = true;
            checkedListBox2.Items.AddRange(new object[] { "дуб", "береза", "ель", "сосна", "лиственница" });
            checkedListBox2.Location = new System.Drawing.Point(315, 42);
            checkedListBox2.Name = "checkedListBox2";
            checkedListBox2.Size = new System.Drawing.Size(150, 293);
            checkedListBox2.TabIndex = 6;
            checkedListBox2.ItemCheck += checkedListBox2_ItemCheck;
            // 
            // label4
            // 
            label4.Dock = System.Windows.Forms.DockStyle.Fill;
            label4.Font = new System.Drawing.Font("Arial Narrow", 12F);
            label4.Location = new System.Drawing.Point(471, 0);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(150, 39);
            label4.TabIndex = 4;
            label4.Text = "Дополнительное\r\nоборудование";
            label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.Dock = System.Windows.Forms.DockStyle.Fill;
            label3.Font = new System.Drawing.Font("Arial Narrow", 12F);
            label3.Location = new System.Drawing.Point(315, 0);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(150, 39);
            label3.TabIndex = 3;
            label3.Text = "Материалы";
            label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.Dock = System.Windows.Forms.DockStyle.Fill;
            label1.Font = new System.Drawing.Font("Arial Narrow", 12F);
            label1.Location = new System.Drawing.Point(159, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(150, 39);
            label1.TabIndex = 2;
            label1.Text = "цвет";
            label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.Dock = System.Windows.Forms.DockStyle.Fill;
            label2.Font = new System.Drawing.Font("Arial Narrow", 12F);
            label2.Location = new System.Drawing.Point(3, 0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(150, 39);
            label2.TabIndex = 1;
            label2.Text = "Асортимент";
            label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // checkedListBox1
            // 
            checkedListBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            checkedListBox1.Font = new System.Drawing.Font("Arial Narrow", 14.1428576F);
            checkedListBox1.FormattingEnabled = true;
            checkedListBox1.HorizontalScrollbar = true;
            checkedListBox1.Items.AddRange(new object[] { "Стандартные модели", "Модели эконом класса", "Модели класса Люкс", "Стандартная комплектация" });
            checkedListBox1.Location = new System.Drawing.Point(3, 42);
            checkedListBox1.Name = "checkedListBox1";
            checkedListBox1.Size = new System.Drawing.Size(150, 293);
            checkedListBox1.TabIndex = 0;
            checkedListBox1.ItemCheck += CheckedListBox_OneItemCheck;
            // 
            // treeView1
            // 
            treeView1.CheckBoxes = true;
            treeView1.Dock = System.Windows.Forms.DockStyle.Fill;
            treeView1.Font = new System.Drawing.Font("Arial Narrow", 14.1428576F);
            treeView1.Location = new System.Drawing.Point(159, 42);
            treeView1.Name = "treeView1";
            treeNode1.BackColor = System.Drawing.Color.Brown;
            treeNode1.Name = "Узел0_1";
            treeNode1.Text = "Коричневый";
            treeNode2.BackColor = System.Drawing.Color.White;
            treeNode2.Name = "Узел0_2";
            treeNode2.Text = "Белый";
            treeNode3.BackColor = System.Drawing.Color.Black;
            treeNode3.ForeColor = System.Drawing.Color.White;
            treeNode3.Name = "Узел0_3";
            treeNode3.Text = "Чёрный";
            treeNode4.BackColor = System.Drawing.Color.Green;
            treeNode4.Name = "Узел0_4";
            treeNode4.Text = "Зелёный";
            treeNode5.BackColor = System.Drawing.Color.Red;
            treeNode5.Name = "Узел0_5";
            treeNode5.Text = "Красный";
            treeNode6.BackColor = System.Drawing.Color.Blue;
            treeNode6.Name = "Узел0_6";
            treeNode6.Text = "Синий";
            treeNode7.Name = "Узел0";
            treeNode7.Text = "Стандартные";
            treeNode8.BackColor = System.Drawing.Color.Coral;
            treeNode8.Name = "Узел1_1";
            treeNode8.Text = "Коралловый";
            treeNode9.BackColor = System.Drawing.Color.Indigo;
            treeNode9.Name = "Узел1_2";
            treeNode9.Text = "Индиго";
            treeNode10.BackColor = System.Drawing.Color.Chocolate;
            treeNode10.Name = "Узел1_3";
            treeNode10.Text = "Шоколадный";
            treeNode11.BackColor = System.Drawing.Color.Turquoise;
            treeNode11.Name = "Узел1_4";
            treeNode11.Text = "Бирюзовый";
            treeNode12.BackColor = System.Drawing.Color.Fuchsia;
            treeNode12.Name = "Узел1_5";
            treeNode12.Text = "Фуксия";
            treeNode13.Name = "Узел1";
            treeNode13.Text = "Другие цвета";
            treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] { treeNode7, treeNode13 });
            treeView1.Size = new System.Drawing.Size(150, 293);
            treeView1.TabIndex = 5;
            treeView1.AfterCheck += treeView1_AfterCheck;
            // 
            // addEquipPanel
            // 
            addEquipPanel.BackColor = System.Drawing.Color.WhiteSmoke;
            addEquipPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            addEquipPanel.Location = new System.Drawing.Point(471, 42);
            addEquipPanel.Name = "addEquipPanel";
            addEquipPanel.Size = new System.Drawing.Size(150, 293);
            addEquipPanel.TabIndex = 7;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            flowLayoutPanel1.Location = new System.Drawing.Point(3, 403);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new System.Drawing.Size(624, 70);
            flowLayoutPanel1.TabIndex = 2;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Dock = System.Windows.Forms.DockStyle.Fill;
            label5.Font = new System.Drawing.Font("Arial Narrow", 15.8571434F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 204);
            label5.Location = new System.Drawing.Point(3, 0);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(624, 56);
            label5.TabIndex = 3;
            label5.Text = "Заказ № 0001";
            label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // startOrderButton
            // 
            startOrderButton.Dock = System.Windows.Forms.DockStyle.Fill;
            startOrderButton.Location = new System.Drawing.Point(633, 403);
            startOrderButton.Name = "startOrderButton";
            startOrderButton.Size = new System.Drawing.Size(152, 70);
            startOrderButton.TabIndex = 4;
            startOrderButton.Text = "Начать выполнять заказ";
            startOrderButton.UseVisualStyleBackColor = true;
            startOrderButton.Click += startOrderButton_Click;
            // 
            // OrderlistBox
            // 
            OrderlistBox.Dock = System.Windows.Forms.DockStyle.Fill;
            OrderlistBox.FormattingEnabled = true;
            OrderlistBox.HorizontalScrollbar = true;
            OrderlistBox.Location = new System.Drawing.Point(633, 59);
            OrderlistBox.Name = "OrderlistBox";
            OrderlistBox.Size = new System.Drawing.Size(152, 338);
            OrderlistBox.TabIndex = 5;
            // 
            // StatusTextBox
            // 
            StatusTextBox.BackColor = System.Drawing.SystemColors.Info;
            StatusTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            StatusTextBox.Enabled = false;
            StatusTextBox.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 204);
            StatusTextBox.Location = new System.Drawing.Point(633, 3);
            StatusTextBox.Multiline = true;
            StatusTextBox.Name = "StatusTextBox";
            StatusTextBox.Size = new System.Drawing.Size(152, 50);
            StatusTextBox.TabIndex = 6;
            StatusTextBox.Text = "Статус заказа\r\nРаботы не начаты";
            StatusTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // OrderForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(788, 476);
            Controls.Add(tableLayoutPanel1);
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            Name = "OrderForm";
            Text = "World yachts";
            FormClosed += OrderForm_FormClosed;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.CheckedListBox checkedListBox2;
        private System.Windows.Forms.Panel addEquipPanel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button startOrderButton;
        private System.Windows.Forms.ListBox OrderlistBox;
        private System.Windows.Forms.TextBox StatusTextBox;
    }
}