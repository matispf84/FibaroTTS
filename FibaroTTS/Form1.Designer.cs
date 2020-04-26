namespace FibaroTTS
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.tbAux = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.sliderVolumen = new System.Windows.Forms.TrackBar();
            this.sliderVelocidad = new System.Windows.Forms.TrackBar();
            this.label2 = new System.Windows.Forms.Label();
            this.Start_Button = new System.Windows.Forms.Button();
            this.Stop_Button = new System.Windows.Forms.Button();
            this.grupoVoz = new System.Windows.Forms.GroupBox();
            this.Status = new System.Windows.Forms.StatusStrip();
            this.tbStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.grupoRed = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.sliderVolumen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sliderVelocidad)).BeginInit();
            this.grupoVoz.SuspendLayout();
            this.Status.SuspendLayout();
            this.grupoRed.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.comboBox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(6, 19);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(250, 21);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // tbAux
            // 
            this.tbAux.Location = new System.Drawing.Point(284, 28);
            this.tbAux.Name = "tbAux";
            this.tbAux.Size = new System.Drawing.Size(262, 108);
            this.tbAux.TabIndex = 1;
            this.tbAux.Text = "";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(284, 141);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(262, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Hablar manualmente";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Volumen";
            // 
            // sliderVolumen
            // 
            this.sliderVolumen.Location = new System.Drawing.Point(6, 59);
            this.sliderVolumen.Maximum = 100;
            this.sliderVolumen.Name = "sliderVolumen";
            this.sliderVolumen.Size = new System.Drawing.Size(250, 45);
            this.sliderVolumen.TabIndex = 5;
            this.sliderVolumen.TickFrequency = 10;
            this.sliderVolumen.Scroll += new System.EventHandler(this.sliderVol_Scroll);
            this.sliderVolumen.ValueChanged += new System.EventHandler(this.sliderVolumen_ValueChanged);
            // 
            // sliderVelocidad
            // 
            this.sliderVelocidad.Location = new System.Drawing.Point(6, 107);
            this.sliderVelocidad.Name = "sliderVelocidad";
            this.sliderVelocidad.Size = new System.Drawing.Size(250, 45);
            this.sliderVelocidad.TabIndex = 7;
            this.sliderVelocidad.Value = 1;
            this.sliderVelocidad.ValueChanged += new System.EventHandler(this.sliderVelocidad_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Velocidad";
            // 
            // Start_Button
            // 
            this.Start_Button.Location = new System.Drawing.Point(366, 198);
            this.Start_Button.Name = "Start_Button";
            this.Start_Button.Size = new System.Drawing.Size(115, 23);
            this.Start_Button.TabIndex = 8;
            this.Start_Button.Text = "Iniciar servicio";
            this.Start_Button.UseVisualStyleBackColor = true;
            this.Start_Button.Click += new System.EventHandler(this.Start_Button_Click);
            // 
            // Stop_Button
            // 
            this.Stop_Button.Location = new System.Drawing.Point(366, 224);
            this.Stop_Button.Name = "Stop_Button";
            this.Stop_Button.Size = new System.Drawing.Size(115, 23);
            this.Stop_Button.TabIndex = 9;
            this.Stop_Button.Text = "Detener";
            this.Stop_Button.UseVisualStyleBackColor = true;
            this.Stop_Button.Click += new System.EventHandler(this.button3_Click);
            // 
            // grupoVoz
            // 
            this.grupoVoz.Controls.Add(this.comboBox1);
            this.grupoVoz.Controls.Add(this.sliderVelocidad);
            this.grupoVoz.Controls.Add(this.label2);
            this.grupoVoz.Controls.Add(this.label1);
            this.grupoVoz.Controls.Add(this.sliderVolumen);
            this.grupoVoz.Location = new System.Drawing.Point(12, 12);
            this.grupoVoz.Name = "grupoVoz";
            this.grupoVoz.Size = new System.Drawing.Size(266, 157);
            this.grupoVoz.TabIndex = 10;
            this.grupoVoz.TabStop = false;
            this.grupoVoz.Text = "Configuración de voz";
            // 
            // Status
            // 
            this.Status.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tbStatus});
            this.Status.Location = new System.Drawing.Point(0, 262);
            this.Status.Name = "Status";
            this.Status.Size = new System.Drawing.Size(554, 22);
            this.Status.TabIndex = 11;
            this.Status.Text = "tbStatus";
            // 
            // tbStatus
            // 
            this.tbStatus.Name = "tbStatus";
            this.tbStatus.Size = new System.Drawing.Size(0, 17);
            // 
            // grupoRed
            // 
            this.grupoRed.Controls.Add(this.label4);
            this.grupoRed.Controls.Add(this.label3);
            this.grupoRed.Controls.Add(this.textBox1);
            this.grupoRed.Controls.Add(this.comboBox2);
            this.grupoRed.Location = new System.Drawing.Point(12, 175);
            this.grupoRed.Name = "grupoRed";
            this.grupoRed.Size = new System.Drawing.Size(266, 82);
            this.grupoRed.TabIndex = 12;
            this.grupoRed.TabStop = false;
            this.grupoRed.Text = "Configuración de red";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Interfaz de red a utilizar";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(173, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Puerto";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(176, 43);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(80, 20);
            this.textBox1.TabIndex = 8;
            this.textBox1.Text = "4510";
            // 
            // comboBox2
            // 
            this.comboBox2.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.comboBox2.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(6, 43);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(164, 21);
            this.comboBox2.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(284, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Texto recibido";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(554, 284);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.grupoRed);
            this.Controls.Add(this.Stop_Button);
            this.Controls.Add(this.tbAux);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Start_Button);
            this.Controls.Add(this.Status);
            this.Controls.Add(this.grupoVoz);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "FibaroTTS";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sliderVolumen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sliderVelocidad)).EndInit();
            this.grupoVoz.ResumeLayout(false);
            this.grupoVoz.PerformLayout();
            this.Status.ResumeLayout(false);
            this.Status.PerformLayout();
            this.grupoRed.ResumeLayout(false);
            this.grupoRed.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.RichTextBox tbAux;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TrackBar sliderVolumen;
        private System.Windows.Forms.TrackBar sliderVelocidad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Start_Button;
        private System.Windows.Forms.Button Stop_Button;
        private System.Windows.Forms.GroupBox grupoVoz;
        private System.Windows.Forms.StatusStrip Status;
        private System.Windows.Forms.ToolStripStatusLabel tbStatus;
        private System.Windows.Forms.GroupBox grupoRed;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label5;
    }
}

