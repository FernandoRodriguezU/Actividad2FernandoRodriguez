namespace SistemasVentas.VISTA.inicio
{
    partial class Vendedor
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
            label1 = new Label();
            button2 = new Button();
            button1 = new Button();
            button3 = new Button();
            dataGridView1 = new DataGridView();
            button4 = new Button();
            panel1 = new Panel();
            button18 = new Button();
            button17 = new Button();
            button16 = new Button();
            button15 = new Button();
            button14 = new Button();
            button13 = new Button();
            button12 = new Button();
            button11 = new Button();
            button10 = new Button();
            button9 = new Button();
            button8 = new Button();
            button7 = new Button();
            button6 = new Button();
            button5 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ImageAlign = ContentAlignment.MiddleLeft;
            label1.Location = new Point(234, 30);
            label1.Name = "label1";
            label1.Size = new Size(349, 50);
            label1.TabIndex = 1;
            label1.Text = " Vendedor Persona";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // button2
            // 
            button2.BackColor = Color.LightSkyBlue;
            button2.FlatAppearance.BorderColor = Color.Blue;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatAppearance.MouseDownBackColor = Color.Blue;
            button2.FlatAppearance.MouseOverBackColor = Color.Blue;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Location = new Point(96, 369);
            button2.Name = "button2";
            button2.Size = new Size(98, 39);
            button2.TabIndex = 6;
            button2.Text = " Listar  Persona";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.LightSkyBlue;
            button1.FlatAppearance.BorderColor = Color.Blue;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatAppearance.MouseDownBackColor = Color.Blue;
            button1.FlatAppearance.MouseOverBackColor = Color.Blue;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(365, 369);
            button1.Name = "button1";
            button1.Size = new Size(98, 39);
            button1.TabIndex = 7;
            button1.Text = "Crear Persona";
            button1.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.BackColor = Color.LightSkyBlue;
            button3.FlatAppearance.BorderColor = Color.Blue;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatAppearance.MouseDownBackColor = Color.Blue;
            button3.FlatAppearance.MouseOverBackColor = Color.Blue;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Location = new Point(582, 369);
            button3.Name = "button3";
            button3.Size = new Size(98, 39);
            button3.TabIndex = 8;
            button3.Text = "Editar Persona";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(176, 83);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(504, 249);
            dataGridView1.TabIndex = 9;
            // 
            // button4
            // 
            button4.BackColor = Color.LightSkyBlue;
            button4.FlatAppearance.BorderColor = Color.Blue;
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatAppearance.MouseDownBackColor = Color.Blue;
            button4.FlatAppearance.MouseOverBackColor = Color.Blue;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Location = new Point(719, 12);
            button4.Name = "button4";
            button4.Size = new Size(69, 31);
            button4.TabIndex = 10;
            button4.Text = "Menu";
            button4.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            panel1.Controls.Add(button18);
            panel1.Controls.Add(button17);
            panel1.Controls.Add(button16);
            panel1.Controls.Add(button15);
            panel1.Controls.Add(button14);
            panel1.Controls.Add(button13);
            panel1.Controls.Add(button12);
            panel1.Controls.Add(button11);
            panel1.Controls.Add(button10);
            panel1.Controls.Add(button9);
            panel1.Controls.Add(button8);
            panel1.Controls.Add(button7);
            panel1.Controls.Add(button6);
            panel1.Controls.Add(button5);
            panel1.Location = new Point(701, 49);
            panel1.Name = "panel1";
            panel1.Size = new Size(103, 389);
            panel1.TabIndex = 11;
            // 
            // button18
            // 
            button18.Location = new Point(3, 287);
            button18.Name = "button18";
            button18.Size = new Size(90, 26);
            button18.TabIndex = 22;
            button18.Text = "Detalle Ing";
            button18.UseVisualStyleBackColor = true;
            // 
            // button17
            // 
            button17.Location = new Point(3, 266);
            button17.Name = "button17";
            button17.Size = new Size(90, 26);
            button17.TabIndex = 21;
            button17.Text = "Detalle Venta";
            button17.UseVisualStyleBackColor = true;
            button17.Click += button17_Click;
            // 
            // button16
            // 
            button16.Location = new Point(18, 243);
            button16.Name = "button16";
            button16.Size = new Size(75, 26);
            button16.TabIndex = 20;
            button16.Text = "Provee";
            button16.UseVisualStyleBackColor = true;
            // 
            // button15
            // 
            button15.Location = new Point(18, 220);
            button15.Name = "button15";
            button15.Size = new Size(75, 26);
            button15.TabIndex = 19;
            button15.Text = "Producto";
            button15.UseVisualStyleBackColor = true;
            button15.Click += button15_Click;
            // 
            // button14
            // 
            button14.Location = new Point(18, 200);
            button14.Name = "button14";
            button14.Size = new Size(75, 23);
            button14.TabIndex = 18;
            button14.Text = "Venta";
            button14.UseVisualStyleBackColor = true;
            // 
            // button13
            // 
            button13.Location = new Point(18, 181);
            button13.Name = "button13";
            button13.Size = new Size(75, 23);
            button13.TabIndex = 17;
            button13.Text = "Ingreso";
            button13.UseVisualStyleBackColor = true;
            // 
            // button12
            // 
            button12.Location = new Point(17, 161);
            button12.Name = "button12";
            button12.Size = new Size(75, 23);
            button12.TabIndex = 16;
            button12.Text = "Cliente";
            button12.UseVisualStyleBackColor = true;
            // 
            // button11
            // 
            button11.Location = new Point(10, 142);
            button11.Name = "button11";
            button11.Size = new Size(82, 23);
            button11.TabIndex = 15;
            button11.Text = " Usuario Rol";
            button11.UseVisualStyleBackColor = true;
            // 
            // button10
            // 
            button10.Location = new Point(18, 122);
            button10.Name = "button10";
            button10.Size = new Size(75, 23);
            button10.TabIndex = 14;
            button10.Text = "Usuario";
            button10.UseVisualStyleBackColor = true;
            // 
            // button9
            // 
            button9.Location = new Point(17, 103);
            button9.Name = "button9";
            button9.Size = new Size(75, 23);
            button9.TabIndex = 13;
            button9.Text = "Proveedor";
            button9.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            button8.Location = new Point(18, 74);
            button8.Name = "button8";
            button8.Size = new Size(75, 23);
            button8.TabIndex = 12;
            button8.Text = "Marca";
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click;
            // 
            // button7
            // 
            button7.Location = new Point(10, 54);
            button7.Name = "button7";
            button7.Size = new Size(90, 23);
            button7.TabIndex = 2;
            button7.Text = "Tipo Producto";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // button6
            // 
            button6.Location = new Point(17, 34);
            button6.Name = "button6";
            button6.Size = new Size(75, 23);
            button6.TabIndex = 1;
            button6.Text = "Rol";
            button6.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Location = new Point(18, 8);
            button5.Name = "button5";
            button5.Size = new Size(75, 23);
            button5.TabIndex = 0;
            button5.Text = " Persona";
            button5.UseVisualStyleBackColor = true;
            // 
            // Vendedor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Controls.Add(button4);
            Controls.Add(dataGridView1);
            Controls.Add(button3);
            Controls.Add(button1);
            Controls.Add(button2);
            Controls.Add(label1);
            Name = "Vendedor";
            Text = "Vendedor";
            Load += Vendedor_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button button2;
        private Button button1;
        private Button button3;
        private DataGridView dataGridView1;
        private Button button4;
        private Panel panel1;
        private Button button5;
        private Button button15;
        private Button button14;
        private Button button13;
        private Button button12;
        private Button button11;
        private Button button10;
        private Button button9;
        private Button button8;
        private Button button7;
        private Button button6;
        private Button button17;
        private Button button16;
        private Button button18;
    }
}