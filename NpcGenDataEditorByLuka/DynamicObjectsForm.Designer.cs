﻿namespace NpcGenDataEditorByLuka
{
    partial class DynamicObjectsForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DynamicObjectsForm));
            this.DynamicGrid = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cancel = new System.Windows.Forms.Button();
            this.Accept = new System.Windows.Forms.Button();
            this.DynamicPictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.DynamicGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DynamicPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // DynamicGrid
            // 
            this.DynamicGrid.AllowUserToAddRows = false;
            this.DynamicGrid.AllowUserToDeleteRows = false;
            this.DynamicGrid.AllowUserToResizeColumns = false;
            this.DynamicGrid.AllowUserToResizeRows = false;
            this.DynamicGrid.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.DynamicGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.DynamicGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.DynamicGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.DynamicGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DynamicGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn12,
            this.dataGridViewTextBoxColumn13,
            this.dataGridViewTextBoxColumn14});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DynamicGrid.DefaultCellStyle = dataGridViewCellStyle4;
            this.DynamicGrid.EnableHeadersVisualStyles = false;
            this.DynamicGrid.Location = new System.Drawing.Point(1, 0);
            this.DynamicGrid.MultiSelect = false;
            this.DynamicGrid.Name = "DynamicGrid";
            this.DynamicGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.DynamicGrid.RowHeadersVisible = false;
            this.DynamicGrid.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.DynamicGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DynamicGrid.ShowCellErrors = false;
            this.DynamicGrid.ShowCellToolTips = false;
            this.DynamicGrid.ShowEditingIcon = false;
            this.DynamicGrid.ShowRowErrors = false;
            this.DynamicGrid.Size = new System.Drawing.Size(303, 335);
            this.DynamicGrid.TabIndex = 18;
            this.DynamicGrid.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DynamicGrid_CellMouseDoubleClick);
            this.DynamicGrid.CurrentCellChanged += new System.EventHandler(this.DynamicGrid_CurrentCellChanged);
            // 
            // dataGridViewTextBoxColumn12
            // 
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dataGridViewTextBoxColumn12.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewTextBoxColumn12.FillWeight = 6.912442F;
            this.dataGridViewTextBoxColumn12.HeaderText = "#";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            this.dataGridViewTextBoxColumn12.ReadOnly = true;
            this.dataGridViewTextBoxColumn12.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dataGridViewTextBoxColumn12.Width = 45;
            // 
            // dataGridViewTextBoxColumn13
            // 
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(255)))), ((int)(((byte)(143)))));
            this.dataGridViewTextBoxColumn13.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewTextBoxColumn13.FillWeight = 44.7233F;
            this.dataGridViewTextBoxColumn13.HeaderText = "  ID";
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            this.dataGridViewTextBoxColumn13.ReadOnly = true;
            this.dataGridViewTextBoxColumn13.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dataGridViewTextBoxColumn13.Width = 60;
            // 
            // dataGridViewTextBoxColumn14
            // 
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            this.dataGridViewTextBoxColumn14.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewTextBoxColumn14.HeaderText = "Name";
            this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            this.dataGridViewTextBoxColumn14.ReadOnly = true;
            this.dataGridViewTextBoxColumn14.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dataGridViewTextBoxColumn14.Width = 195;
            // 
            // Cancel
            // 
            this.Cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Cancel.Image = global::NpcGenDataEditorByLuka.Properties.Resources.CancelDynamic;
            this.Cancel.Location = new System.Drawing.Point(535, 263);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(228, 72);
            this.Cancel.TabIndex = 21;
            this.Cancel.Text = "Отменить";
            this.Cancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Cancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // Accept
            // 
            this.Accept.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Accept.Image = global::NpcGenDataEditorByLuka.Properties.Resources.DynamicAccept;
            this.Accept.Location = new System.Drawing.Point(307, 263);
            this.Accept.Name = "Accept";
            this.Accept.Size = new System.Drawing.Size(228, 72);
            this.Accept.TabIndex = 20;
            this.Accept.Text = "Принять";
            this.Accept.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Accept.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Accept.UseVisualStyleBackColor = true;
            this.Accept.Click += new System.EventHandler(this.Accept_Click);
            // 
            // DynamicPictureBox
            // 
            this.DynamicPictureBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.DynamicPictureBox.Location = new System.Drawing.Point(307, 0);
            this.DynamicPictureBox.Name = "DynamicPictureBox";
            this.DynamicPictureBox.Size = new System.Drawing.Size(456, 257);
            this.DynamicPictureBox.TabIndex = 19;
            this.DynamicPictureBox.TabStop = false;
            // 
            // DynamicObjectsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(765, 336);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.Accept);
            this.Controls.Add(this.DynamicPictureBox);
            this.Controls.Add(this.DynamicGrid);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DynamicObjectsForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Choose Dynamic object";
            ((System.ComponentModel.ISupportInitialize)(this.DynamicGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DynamicPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DynamicGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        private System.Windows.Forms.PictureBox DynamicPictureBox;
        private System.Windows.Forms.Button Accept;
        private System.Windows.Forms.Button Cancel;
    }
}