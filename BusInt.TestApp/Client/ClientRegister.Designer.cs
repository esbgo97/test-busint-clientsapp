namespace BusInt.TestApp.Client
{
    partial class ClientRegister
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
            groupBox1 = new GroupBox();
            cmbDocType = new ComboBox();
            label5 = new Label();
            txtDocument = new TextBox();
            label4 = new Label();
            txtLastName = new TextBox();
            label3 = new Label();
            label2 = new Label();
            txtName = new TextBox();
            groupBox2 = new GroupBox();
            txtEmail = new TextBox();
            label13 = new Label();
            cmbCity = new ComboBox();
            label10 = new Label();
            cmbCountry = new ComboBox();
            label9 = new Label();
            txtNeighbornhood = new TextBox();
            label8 = new Label();
            txtAddress = new TextBox();
            label7 = new Label();
            label6 = new Label();
            txtPhone = new TextBox();
            groupBox3 = new GroupBox();
            dtmBirth = new DateTimePicker();
            label15 = new Label();
            txtJob = new TextBox();
            label14 = new Label();
            label12 = new Label();
            numChild = new NumericUpDown();
            label11 = new Label();
            cmbCivilStatus = new ComboBox();
            groupBox4 = new GroupBox();
            chkData = new CheckBox();
            chkNotification = new CheckBox();
            chkTerms = new CheckBox();
            button1 = new Button();
            button2 = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numChild).BeginInit();
            groupBox4.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(11, 9);
            label1.Name = "label1";
            label1.Size = new Size(372, 20);
            label1.TabIndex = 0;
            label1.Text = "Complete el formulario para registrar un cliente nuevo.";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(cmbDocType);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(txtDocument);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(txtLastName);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtName);
            groupBox1.Location = new Point(27, 45);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(489, 219);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "Datos básicos";
            // 
            // cmbDocType
            // 
            cmbDocType.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cmbDocType.FormattingEnabled = true;
            cmbDocType.Location = new Point(245, 41);
            cmbDocType.Name = "cmbDocType";
            cmbDocType.Size = new Size(238, 36);
            cmbDocType.TabIndex = 12;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(6, 49);
            label5.Name = "label5";
            label5.Size = new Size(163, 28);
            label5.TabIndex = 11;
            label5.Text = "Tipo Documento:";
            // 
            // txtDocument
            // 
            txtDocument.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtDocument.Location = new Point(245, 83);
            txtDocument.Name = "txtDocument";
            txtDocument.Size = new Size(238, 34);
            txtDocument.TabIndex = 10;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(6, 88);
            label4.Name = "label4";
            label4.Size = new Size(162, 28);
            label4.TabIndex = 9;
            label4.Text = "Nro. Documento:";
            // 
            // txtLastName
            // 
            txtLastName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtLastName.Location = new Point(245, 164);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(238, 34);
            txtLastName.TabIndex = 8;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(6, 171);
            label3.Name = "label3";
            label3.Size = new Size(98, 28);
            label3.TabIndex = 7;
            label3.Text = "Apellidos:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(6, 131);
            label2.Name = "label2";
            label2.Size = new Size(97, 28);
            label2.TabIndex = 6;
            label2.Text = "Nombres:";
            // 
            // txtName
            // 
            txtName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtName.Location = new Point(245, 124);
            txtName.Name = "txtName";
            txtName.Size = new Size(238, 34);
            txtName.TabIndex = 5;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(txtEmail);
            groupBox2.Controls.Add(label13);
            groupBox2.Controls.Add(cmbCity);
            groupBox2.Controls.Add(label10);
            groupBox2.Controls.Add(cmbCountry);
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(txtNeighbornhood);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(txtAddress);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(txtPhone);
            groupBox2.Location = new Point(33, 283);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(483, 376);
            groupBox2.TabIndex = 6;
            groupBox2.TabStop = false;
            groupBox2.Text = "Contacto";
            groupBox2.Enter += groupBox2_Enter;
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtEmail.Location = new Point(239, 92);
            txtEmail.Margin = new Padding(3, 4, 3, 4);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(238, 34);
            txtEmail.TabIndex = 11;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label13.Location = new Point(6, 103);
            label13.Name = "label13";
            label13.Size = new Size(76, 28);
            label13.TabIndex = 10;
            label13.Text = "Correo:";
            // 
            // cmbCity
            // 
            cmbCity.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cmbCity.FormattingEnabled = true;
            cmbCity.Location = new Point(239, 237);
            cmbCity.Margin = new Padding(3, 4, 3, 4);
            cmbCity.Name = "cmbCity";
            cmbCity.Size = new Size(237, 36);
            cmbCity.TabIndex = 9;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(7, 248);
            label10.Name = "label10";
            label10.Size = new Size(78, 28);
            label10.TabIndex = 8;
            label10.Text = "Ciudad:";
            // 
            // cmbCountry
            // 
            cmbCountry.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cmbCountry.FormattingEnabled = true;
            cmbCountry.Location = new Point(239, 191);
            cmbCountry.Margin = new Padding(3, 4, 3, 4);
            cmbCountry.Name = "cmbCountry";
            cmbCountry.Size = new Size(238, 36);
            cmbCountry.TabIndex = 7;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(7, 201);
            label9.Name = "label9";
            label9.Size = new Size(49, 28);
            label9.TabIndex = 6;
            label9.Text = "País:";
            label9.Click += label9_Click;
            // 
            // txtNeighbornhood
            // 
            txtNeighbornhood.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtNeighbornhood.Location = new Point(238, 331);
            txtNeighbornhood.Margin = new Padding(3, 4, 3, 4);
            txtNeighbornhood.Name = "txtNeighbornhood";
            txtNeighbornhood.Size = new Size(238, 34);
            txtNeighbornhood.TabIndex = 5;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(7, 345);
            label8.Name = "label8";
            label8.Size = new Size(68, 28);
            label8.TabIndex = 4;
            label8.Text = "Barrio:";
            // 
            // txtAddress
            // 
            txtAddress.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtAddress.Location = new Point(238, 284);
            txtAddress.Margin = new Padding(3, 4, 3, 4);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(238, 34);
            txtAddress.TabIndex = 3;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(7, 295);
            label7.Name = "label7";
            label7.Size = new Size(98, 28);
            label7.TabIndex = 2;
            label7.Text = "Dirección:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(6, 47);
            label6.Name = "label6";
            label6.Size = new Size(90, 28);
            label6.TabIndex = 1;
            label6.Text = "Teléfono:";
            // 
            // txtPhone
            // 
            txtPhone.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtPhone.Location = new Point(239, 41);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(238, 34);
            txtPhone.TabIndex = 0;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(dtmBirth);
            groupBox3.Controls.Add(label15);
            groupBox3.Controls.Add(txtJob);
            groupBox3.Controls.Add(label14);
            groupBox3.Controls.Add(label12);
            groupBox3.Controls.Add(numChild);
            groupBox3.Controls.Add(label11);
            groupBox3.Controls.Add(cmbCivilStatus);
            groupBox3.Location = new Point(535, 45);
            groupBox3.Margin = new Padding(3, 4, 3, 4);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(3, 4, 3, 4);
            groupBox3.Size = new Size(489, 219);
            groupBox3.TabIndex = 7;
            groupBox3.TabStop = false;
            groupBox3.Text = "Datos Personales";
            // 
            // dtmBirth
            // 
            dtmBirth.CalendarFont = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dtmBirth.Location = new Point(267, 39);
            dtmBirth.Margin = new Padding(3, 4, 3, 4);
            dtmBirth.Name = "dtmBirth";
            dtmBirth.Size = new Size(214, 27);
            dtmBirth.TabIndex = 7;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label15.Location = new Point(7, 41);
            label15.Name = "label15";
            label15.Size = new Size(199, 28);
            label15.TabIndex = 6;
            label15.Text = "Fecha de Nacimiento:";
            // 
            // txtJob
            // 
            txtJob.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtJob.Location = new Point(267, 164);
            txtJob.Margin = new Padding(3, 4, 3, 4);
            txtJob.Name = "txtJob";
            txtJob.Size = new Size(214, 34);
            txtJob.TabIndex = 5;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label14.Location = new Point(7, 175);
            label14.Name = "label14";
            label14.Size = new Size(98, 28);
            label14.TabIndex = 4;
            label14.Text = "Profesión:";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label12.Location = new Point(7, 129);
            label12.Name = "label12";
            label12.Size = new Size(164, 28);
            label12.TabIndex = 3;
            label12.Text = "Numero de Hijos:";
            // 
            // numChild
            // 
            numChild.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            numChild.Location = new Point(267, 119);
            numChild.Name = "numChild";
            numChild.Size = new Size(215, 34);
            numChild.TabIndex = 2;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label11.Location = new Point(7, 84);
            label11.Name = "label11";
            label11.Size = new Size(117, 28);
            label11.TabIndex = 1;
            label11.Text = "Estado Civil:";
            // 
            // cmbCivilStatus
            // 
            cmbCivilStatus.DropDownWidth = 209;
            cmbCivilStatus.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cmbCivilStatus.FormattingEnabled = true;
            cmbCivilStatus.Location = new Point(267, 73);
            cmbCivilStatus.Margin = new Padding(3, 4, 3, 4);
            cmbCivilStatus.Name = "cmbCivilStatus";
            cmbCivilStatus.Size = new Size(214, 36);
            cmbCivilStatus.TabIndex = 0;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(chkData);
            groupBox4.Controls.Add(chkNotification);
            groupBox4.Controls.Add(chkTerms);
            groupBox4.Location = new Point(535, 283);
            groupBox4.Margin = new Padding(3, 4, 3, 4);
            groupBox4.Name = "groupBox4";
            groupBox4.Padding = new Padding(3, 4, 3, 4);
            groupBox4.Size = new Size(489, 241);
            groupBox4.TabIndex = 8;
            groupBox4.TabStop = false;
            groupBox4.Text = "Autorización de Datos";
            // 
            // chkData
            // 
            chkData.AutoSize = true;
            chkData.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            chkData.Location = new Point(7, 97);
            chkData.Margin = new Padding(3, 4, 3, 4);
            chkData.Name = "chkData";
            chkData.Size = new Size(401, 32);
            chkData.TabIndex = 2;
            chkData.Text = "Acepto Tratamiento de Datos con terceros";
            chkData.UseVisualStyleBackColor = true;
            // 
            // chkNotification
            // 
            chkNotification.AutoSize = true;
            chkNotification.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            chkNotification.Location = new Point(7, 196);
            chkNotification.Margin = new Padding(3, 4, 3, 4);
            chkNotification.Name = "chkNotification";
            chkNotification.Size = new Size(327, 32);
            chkNotification.TabIndex = 1;
            chkNotification.Text = "Acepto Notificaciones por Correo";
            chkNotification.UseVisualStyleBackColor = true;
            // 
            // chkTerms
            // 
            chkTerms.AutoSize = true;
            chkTerms.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            chkTerms.Location = new Point(7, 47);
            chkTerms.Margin = new Padding(3, 4, 3, 4);
            chkTerms.Name = "chkTerms";
            chkTerms.Size = new Size(307, 32);
            chkTerms.TabIndex = 0;
            chkTerms.Text = "Acepto Términos y Condiciones";
            chkTerms.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.BackColor = Color.LightGreen;
            button1.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(698, 532);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(139, 73);
            button1.TabIndex = 9;
            button1.Text = "Guardar";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.LightCoral;
            button2.Location = new Point(723, 613);
            button2.Margin = new Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Size = new Size(86, 31);
            button2.TabIndex = 10;
            button2.Text = "Cancelar";
            button2.UseVisualStyleBackColor = false;
            // 
            // ClientRegister
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1042, 673);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Name = "ClientRegister";
            Text = "AppTest - Registrar Cliente";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numChild).EndInit();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private GroupBox groupBox1;
        private Label label4;
        private TextBox txtLastName;
        private Label label3;
        private Label label2;
        private TextBox txtName;
        private TextBox txtDocument;
        private ComboBox cmbDocType;
        private Label label5;
        private GroupBox groupBox2;
        private Label label6;
        private TextBox txtPhone;
        private TextBox txtNeighbornhood;
        private Label label8;
        private TextBox txtAddress;
        private Label label7;
        private Label label9;
        private ComboBox cmbCountry;
        private ComboBox cmbCity;
        private Label label10;
        private GroupBox groupBox3;
        private Label label12;
        private NumericUpDown numChild;
        private Label label11;
        private ComboBox cmbCivilStatus;
        private TextBox txtEmail;
        private Label label13;
        private TextBox txtJob;
        private Label label14;
        private GroupBox groupBox4;
        private CheckBox chkData;
        private CheckBox chkNotification;
        private CheckBox chkTerms;
        private Button button1;
        private Button button2;
        private DateTimePicker dtmBirth;
        private Label label15;
    }
}