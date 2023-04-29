using System.Net;

namespace ImdbTopMovies
{
    partial class FormMovies
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
            dataGridView1 = new DataGridView();
            buttonSearch = new Button();
            textSearch = new TextBox();
            labelResult = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView1.BackgroundColor = SystemColors.Info;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.GridColor = SystemColors.Control;
            dataGridView1.Location = new Point(220, 16);
            dataGridView1.Margin = new Padding(2, 1, 2, 1);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 82;
            dataGridView1.RowTemplate.Height = 41;
            dataGridView1.Size = new Size(528, 355);
            dataGridView1.TabIndex = 0;
            // 
            // buttonSearch
            // 
            buttonSearch.BackColor = SystemColors.ActiveCaption;
            buttonSearch.Location = new Point(15, 41);
            buttonSearch.Margin = new Padding(1);
            buttonSearch.Name = "buttonSearch";
            buttonSearch.Size = new Size(148, 22);
            buttonSearch.TabIndex = 1;
            buttonSearch.Text = "Search";
            buttonSearch.UseVisualStyleBackColor = false;
            buttonSearch.Click += buttonSearch_Click;
            // 
            // textSearch
            // 
            textSearch.Location = new Point(15, 16);
            textSearch.Margin = new Padding(1);
            textSearch.Name = "textSearch";
            textSearch.Size = new Size(150, 23);
            textSearch.TabIndex = 2;
            textSearch.TextChanged += textSearch_TextChanged;
            // 
            // labelResult
            // 
            labelResult.AutoSize = true;
            labelResult.BackColor = Color.Transparent;
            labelResult.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            labelResult.Location = new Point(6, 78);
            labelResult.Margin = new Padding(1, 0, 1, 0);
            labelResult.Name = "labelResult";
            labelResult.Size = new Size(0, 21);
            labelResult.TabIndex = 3;
            labelResult.Click += label1_Click;
            // 
            // FormMovies
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.book;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(825, 403);
            Controls.Add(labelResult);
            Controls.Add(textSearch);
            Controls.Add(buttonSearch);
            Controls.Add(dataGridView1);
            Margin = new Padding(2, 1, 2, 1);
            Name = "FormMovies";
            Text = "IMDB Top 250 Movies";
            Load += FormMovies_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion





        private DataGridView dataGridView1;
        private Button buttonSearch;
        private TextBox textSearch;
        private Label labelResult;
    }





}