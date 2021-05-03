
namespace ChuckNorrisForm
{
    partial class Form1
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
            this.jokeButton = new System.Windows.Forms.Button();
            this.jokeComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // jokeButton
            // 
            this.jokeButton.Location = new System.Drawing.Point(107, 271);
            this.jokeButton.Name = "jokeButton";
            this.jokeButton.Size = new System.Drawing.Size(303, 120);
            this.jokeButton.TabIndex = 0;
            this.jokeButton.Text = "Click For Random Joke";
            this.jokeButton.UseVisualStyleBackColor = true;
            this.jokeButton.Click += new System.EventHandler(this.jokeButton_Click);
            // 
            // jokeComboBox
            // 
            this.jokeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.jokeComboBox.FormattingEnabled = true;
            this.jokeComboBox.Location = new System.Drawing.Point(107, 131);
            this.jokeComboBox.Name = "jokeComboBox";
            this.jokeComboBox.Size = new System.Drawing.Size(303, 33);
            this.jokeComboBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Chuck Norris Joke";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(522, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.jokeComboBox);
            this.Controls.Add(this.jokeButton);
            this.Name = "Form1";
            this.Text = "Chuck Norris Joke";
            this.Load += new System.EventHandler(this.ChuckNorrisForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button jokeButton;
        private System.Windows.Forms.ComboBox jokeComboBox;
        private System.Windows.Forms.Label label1;
    }
}

