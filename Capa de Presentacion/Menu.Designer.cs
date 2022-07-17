namespace Capa_de_Presentacion
{
    partial class Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.btnTextEditor = new System.Windows.Forms.Button();
            this.btnFPaint = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnTextEditor
            // 
            this.btnTextEditor.Image = ((System.Drawing.Image)(resources.GetObject("btnTextEditor.Image")));
            this.btnTextEditor.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnTextEditor.Location = new System.Drawing.Point(38, 35);
            this.btnTextEditor.Name = "btnTextEditor";
            this.btnTextEditor.Size = new System.Drawing.Size(134, 130);
            this.btnTextEditor.TabIndex = 0;
            this.btnTextEditor.Text = "Text Editor";
            this.btnTextEditor.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnTextEditor.UseVisualStyleBackColor = true;
            this.btnTextEditor.Click += new System.EventHandler(this.btnTextEditor_Click);
            // 
            // btnFPaint
            // 
            this.btnFPaint.Image = ((System.Drawing.Image)(resources.GetObject("btnFPaint.Image")));
            this.btnFPaint.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnFPaint.Location = new System.Drawing.Point(221, 35);
            this.btnFPaint.Name = "btnFPaint";
            this.btnFPaint.Size = new System.Drawing.Size(134, 130);
            this.btnFPaint.TabIndex = 1;
            this.btnFPaint.Text = "FPaint";
            this.btnFPaint.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnFPaint.UseVisualStyleBackColor = true;
            this.btnFPaint.Click += new System.EventHandler(this.btnFPaint_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(403, 206);
            this.Controls.Add(this.btnFPaint);
            this.Controls.Add(this.btnTextEditor);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnTextEditor;
        private Button btnFPaint;
    }
}