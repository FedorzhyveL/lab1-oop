namespace Lab_1
{
    partial class Lab_1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.arrivalTimeLabel = new System.Windows.Forms.Label();
            this.orderTimeIntervalLabel = new System.Windows.Forms.Label();
            this.startButton = new System.Windows.Forms.Button();
            this.ordersGrupBox = new System.Windows.Forms.GroupBox();
            this.currentOrderNumberTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.orderLineTextBox = new System.Windows.Forms.TextBox();
            this.kitchenGroupBox = new System.Windows.Forms.GroupBox();
            this.oredersAmountTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.preparingOrderTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.orderNumberGridView = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.waitingCustomersNumberTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.orderAvailableForPickupTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.stopButton = new System.Windows.Forms.Button();
            this.arrivalTimeUpDown = new System.Windows.Forms.NumericUpDown();
            this.fulfilmentTimeUpDown = new System.Windows.Forms.NumericUpDown();
            this.btn_restart = new System.Windows.Forms.Button();
            this.ordersGrupBox.SuspendLayout();
            this.kitchenGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.orderNumberGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.arrivalTimeUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fulfilmentTimeUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // arrivalTimeLabel
            // 
            this.arrivalTimeLabel.AutoSize = true;
            this.arrivalTimeLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.arrivalTimeLabel.Location = new System.Drawing.Point(188, 18);
            this.arrivalTimeLabel.Name = "arrivalTimeLabel";
            this.arrivalTimeLabel.Size = new System.Drawing.Size(305, 24);
            this.arrivalTimeLabel.TabIndex = 0;
            this.arrivalTimeLabel.Text = "Интервал прибытия клиентов";
            // 
            // orderTimeIntervalLabel
            // 
            this.orderTimeIntervalLabel.AutoSize = true;
            this.orderTimeIntervalLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.orderTimeIntervalLabel.Location = new System.Drawing.Point(602, 18);
            this.orderTimeIntervalLabel.Name = "orderTimeIntervalLabel";
            this.orderTimeIntervalLabel.Size = new System.Drawing.Size(212, 24);
            this.orderTimeIntervalLabel.TabIndex = 2;
            this.orderTimeIntervalLabel.Text = "Время обсуживания";
            // 
            // startButton
            // 
            this.startButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.startButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.startButton.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.startButton.Location = new System.Drawing.Point(299, 114);
            this.startButton.Margin = new System.Windows.Forms.Padding(0);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(114, 56);
            this.startButton.TabIndex = 4;
            this.startButton.Text = "Старт";
            this.startButton.UseVisualStyleBackColor = false;
            this.startButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // ordersGrupBox
            // 
            this.ordersGrupBox.Controls.Add(this.currentOrderNumberTextBox);
            this.ordersGrupBox.Controls.Add(this.label2);
            this.ordersGrupBox.Controls.Add(this.label1);
            this.ordersGrupBox.Controls.Add(this.orderLineTextBox);
            this.ordersGrupBox.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ordersGrupBox.Location = new System.Drawing.Point(12, 197);
            this.ordersGrupBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ordersGrupBox.Name = "ordersGrupBox";
            this.ordersGrupBox.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ordersGrupBox.Size = new System.Drawing.Size(280, 247);
            this.ordersGrupBox.TabIndex = 5;
            this.ordersGrupBox.TabStop = false;
            this.ordersGrupBox.Text = "Заказы";
            // 
            // currentOrderNumberTextBox
            // 
            this.currentOrderNumberTextBox.BackColor = System.Drawing.SystemColors.Control;
            this.currentOrderNumberTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.currentOrderNumberTextBox.Enabled = false;
            this.currentOrderNumberTextBox.Font = new System.Drawing.Font("Arial", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.currentOrderNumberTextBox.Location = new System.Drawing.Point(186, 148);
            this.currentOrderNumberTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.currentOrderNumberTextBox.Name = "currentOrderNumberTextBox";
            this.currentOrderNumberTextBox.Size = new System.Drawing.Size(85, 42);
            this.currentOrderNumberTextBox.TabIndex = 8;
            this.currentOrderNumberTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(7, 148);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(195, 44);
            this.label2.TabIndex = 7;
            this.label2.Text = "Номер текущего заказа";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(7, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 68);
            this.label1.TabIndex = 6;
            this.label1.Text = "Клиенты желающие сделать заказ";
            // 
            // orderLineTextBox
            // 
            this.orderLineTextBox.BackColor = System.Drawing.SystemColors.Control;
            this.orderLineTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.orderLineTextBox.Enabled = false;
            this.orderLineTextBox.Font = new System.Drawing.Font("Arial", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.orderLineTextBox.Location = new System.Drawing.Point(186, 55);
            this.orderLineTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.orderLineTextBox.Name = "orderLineTextBox";
            this.orderLineTextBox.Size = new System.Drawing.Size(85, 42);
            this.orderLineTextBox.TabIndex = 0;
            this.orderLineTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // kitchenGroupBox
            // 
            this.kitchenGroupBox.Controls.Add(this.oredersAmountTextBox);
            this.kitchenGroupBox.Controls.Add(this.label4);
            this.kitchenGroupBox.Controls.Add(this.preparingOrderTextBox);
            this.kitchenGroupBox.Controls.Add(this.label3);
            this.kitchenGroupBox.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.kitchenGroupBox.Location = new System.Drawing.Point(313, 197);
            this.kitchenGroupBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.kitchenGroupBox.Name = "kitchenGroupBox";
            this.kitchenGroupBox.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.kitchenGroupBox.Size = new System.Drawing.Size(280, 247);
            this.kitchenGroupBox.TabIndex = 6;
            this.kitchenGroupBox.TabStop = false;
            this.kitchenGroupBox.Text = "Кухня";
            // 
            // oredersAmountTextBox
            // 
            this.oredersAmountTextBox.BackColor = System.Drawing.SystemColors.Control;
            this.oredersAmountTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.oredersAmountTextBox.Enabled = false;
            this.oredersAmountTextBox.Font = new System.Drawing.Font("Arial", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.oredersAmountTextBox.Location = new System.Drawing.Point(180, 148);
            this.oredersAmountTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.oredersAmountTextBox.Name = "oredersAmountTextBox";
            this.oredersAmountTextBox.Size = new System.Drawing.Size(85, 42);
            this.oredersAmountTextBox.TabIndex = 12;
            this.oredersAmountTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(7, 148);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(177, 22);
            this.label4.TabIndex = 11;
            this.label4.Text = "Количество заказов";
            // 
            // preparingOrderTextBox
            // 
            this.preparingOrderTextBox.BackColor = System.Drawing.SystemColors.Control;
            this.preparingOrderTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.preparingOrderTextBox.Enabled = false;
            this.preparingOrderTextBox.Font = new System.Drawing.Font("Arial", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.preparingOrderTextBox.Location = new System.Drawing.Point(180, 55);
            this.preparingOrderTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.preparingOrderTextBox.Name = "preparingOrderTextBox";
            this.preparingOrderTextBox.Size = new System.Drawing.Size(85, 42);
            this.preparingOrderTextBox.TabIndex = 9;
            this.preparingOrderTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(7, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(172, 44);
            this.label3.TabIndex = 9;
            this.label3.Text = "Заказ который готовится";
            // 
            // orderNumberGridView
            // 
            this.orderNumberGridView.AllowUserToAddRows = false;
            this.orderNumberGridView.AllowUserToDeleteRows = false;
            this.orderNumberGridView.BackgroundColor = System.Drawing.SystemColors.Control;
            this.orderNumberGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.orderNumberGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1});
            this.orderNumberGridView.GridColor = System.Drawing.SystemColors.Control;
            this.orderNumberGridView.Location = new System.Drawing.Point(602, 210);
            this.orderNumberGridView.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.orderNumberGridView.Name = "orderNumberGridView";
            this.orderNumberGridView.ReadOnly = true;
            this.orderNumberGridView.RowHeadersWidth = 51;
            this.orderNumberGridView.RowTemplate.Height = 25;
            this.orderNumberGridView.Size = new System.Drawing.Size(180, 234);
            this.orderNumberGridView.TabIndex = 10;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Номера заказов";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 125;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.waitingCustomersNumberTextBox);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.orderAvailableForPickupTextBox);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(791, 197);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(280, 247);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Выдача заказов";
            // 
            // waitingCustomersNumberTextBox
            // 
            this.waitingCustomersNumberTextBox.BackColor = System.Drawing.SystemColors.Control;
            this.waitingCustomersNumberTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.waitingCustomersNumberTextBox.Enabled = false;
            this.waitingCustomersNumberTextBox.Font = new System.Drawing.Font("Arial", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.waitingCustomersNumberTextBox.Location = new System.Drawing.Point(180, 140);
            this.waitingCustomersNumberTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.waitingCustomersNumberTextBox.Name = "waitingCustomersNumberTextBox";
            this.waitingCustomersNumberTextBox.Size = new System.Drawing.Size(85, 42);
            this.waitingCustomersNumberTextBox.TabIndex = 11;
            this.waitingCustomersNumberTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(7, 140);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(169, 87);
            this.label6.TabIndex = 10;
            this.label6.Text = "Количество клиентов ждущих заказ";
            // 
            // orderAvailableForPickupTextBox
            // 
            this.orderAvailableForPickupTextBox.BackColor = System.Drawing.SystemColors.Control;
            this.orderAvailableForPickupTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.orderAvailableForPickupTextBox.Enabled = false;
            this.orderAvailableForPickupTextBox.Font = new System.Drawing.Font("Arial", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.orderAvailableForPickupTextBox.Location = new System.Drawing.Point(180, 53);
            this.orderAvailableForPickupTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.orderAvailableForPickupTextBox.Name = "orderAvailableForPickupTextBox";
            this.orderAvailableForPickupTextBox.Size = new System.Drawing.Size(85, 42);
            this.orderAvailableForPickupTextBox.TabIndex = 9;
            this.orderAvailableForPickupTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(7, 51);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(156, 46);
            this.label5.TabIndex = 9;
            this.label5.Text = "Заказ готовый к выдаче";
            // 
            // stopButton
            // 
            this.stopButton.BackColor = System.Drawing.Color.Red;
            this.stopButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.stopButton.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.stopButton.Location = new System.Drawing.Point(645, 114);
            this.stopButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.stopButton.Name = "stopButton";
            this.stopButton.Size = new System.Drawing.Size(114, 56);
            this.stopButton.TabIndex = 8;
            this.stopButton.Text = "Стоп";
            this.stopButton.UseVisualStyleBackColor = false;
            this.stopButton.Click += new System.EventHandler(this.StopButton_Click);
            // 
            // arrivalTimeUpDown
            // 
            this.arrivalTimeUpDown.BackColor = System.Drawing.SystemColors.Control;
            this.arrivalTimeUpDown.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.arrivalTimeUpDown.Location = new System.Drawing.Point(299, 46);
            this.arrivalTimeUpDown.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.arrivalTimeUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.arrivalTimeUpDown.Name = "arrivalTimeUpDown";
            this.arrivalTimeUpDown.Size = new System.Drawing.Size(114, 34);
            this.arrivalTimeUpDown.TabIndex = 9;
            this.arrivalTimeUpDown.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // fulfilmentTimeUpDown
            // 
            this.fulfilmentTimeUpDown.BackColor = System.Drawing.SystemColors.Control;
            this.fulfilmentTimeUpDown.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.fulfilmentTimeUpDown.Location = new System.Drawing.Point(645, 46);
            this.fulfilmentTimeUpDown.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.fulfilmentTimeUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.fulfilmentTimeUpDown.Name = "fulfilmentTimeUpDown";
            this.fulfilmentTimeUpDown.Size = new System.Drawing.Size(111, 34);
            this.fulfilmentTimeUpDown.TabIndex = 10;
            this.fulfilmentTimeUpDown.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            // 
            // btn_restart
            // 
            this.btn_restart.BackColor = System.Drawing.Color.Yellow;
            this.btn_restart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_restart.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_restart.Location = new System.Drawing.Point(479, 114);
            this.btn_restart.Name = "btn_restart";
            this.btn_restart.Size = new System.Drawing.Size(114, 56);
            this.btn_restart.TabIndex = 11;
            this.btn_restart.Text = "Рестарт";
            this.btn_restart.UseVisualStyleBackColor = false;
            this.btn_restart.Click += new System.EventHandler(this.btn_restart_Click);
            // 
            // Lab_1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1083, 637);
            this.Controls.Add(this.btn_restart);
            this.Controls.Add(this.fulfilmentTimeUpDown);
            this.Controls.Add(this.orderNumberGridView);
            this.Controls.Add(this.arrivalTimeUpDown);
            this.Controls.Add(this.stopButton);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.kitchenGroupBox);
            this.Controls.Add(this.ordersGrupBox);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.orderTimeIntervalLabel);
            this.Controls.Add(this.arrivalTimeLabel);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Lab_1";
            this.Text = "Живель+Стома ПОИТ-201";
            this.ordersGrupBox.ResumeLayout(false);
            this.ordersGrupBox.PerformLayout();
            this.kitchenGroupBox.ResumeLayout(false);
            this.kitchenGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.orderNumberGridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.arrivalTimeUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fulfilmentTimeUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label arrivalTimeLabel;
        private Label orderTimeIntervalLabel;
        private Button startButton;
        private GroupBox ordersGrupBox;
        private TextBox orderLineTextBox;
        private TextBox currentOrderNumberTextBox;
        private Label label2;
        private Label label1;
        private GroupBox kitchenGroupBox;
        private Label label4;
        private DataGridView orderNumberGridView;
        private TextBox preparingOrderTextBox;
        private Label label3;
        private TextBox oredersAmountTextBox;
        private GroupBox groupBox1;
        private Label label5;
        private TextBox orderAvailableForPickupTextBox;
        private TextBox waitingCustomersNumberTextBox;
        private Label label6;
        private Button stopButton;
        private NumericUpDown arrivalTimeUpDown;
        private NumericUpDown fulfilmentTimeUpDown;
        private Button btn_restart;
        private DataGridViewTextBoxColumn Column1;
    }
}