﻿namespace FreshStart
{
    partial class FormEvaluaciones
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
            this.labeIPregunta = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labeIPregunta
            // 
            this.labeIPregunta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labeIPregunta.Font = new System.Drawing.Font("Bahnschrift Condensed", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labeIPregunta.Location = new System.Drawing.Point(36, 9);
            this.labeIPregunta.Name = "labeIPregunta";
            this.labeIPregunta.Size = new System.Drawing.Size(830, 96);
            this.labeIPregunta.TabIndex = 3;
            this.labeIPregunta.Text = "Iniciar Sesión";
            this.labeIPregunta.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Bahnschrift Light", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(189, 120);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(527, 56);
            this.button1.TabIndex = 4;
            this.button1.Tag = "1";
            this.button1.Text = "Respuesta 1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Bahnschrift Light", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button2.Location = new System.Drawing.Point(189, 225);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(527, 56);
            this.button2.TabIndex = 5;
            this.button2.Tag = "2";
            this.button2.Text = "Respuesta 2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Bahnschrift Light", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button3.Location = new System.Drawing.Point(189, 329);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(527, 56);
            this.button3.TabIndex = 6;
            this.button3.Tag = "3";
            this.button3.Text = "Respuesta 3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Bahnschrift Light", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button4.Location = new System.Drawing.Point(189, 426);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(527, 56);
            this.button4.TabIndex = 7;
            this.button4.Tag = "4";
            this.button4.Text = "Respuesta 4";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button_Click);
            // 
            // FormEvaluaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(234)))), ((int)(((byte)(234)))));
            this.ClientSize = new System.Drawing.Size(929, 546);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.labeIPregunta);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormEvaluaciones";
            this.Text = "FormEvaluaciones";
            this.Load += new System.EventHandler(this.FormEvaluaciones_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Label labeIPregunta;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
    }
}