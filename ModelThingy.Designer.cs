namespace LM2L
{
    partial class ModelThingy
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
            // Seemingly left out of the original code. Why?
        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private OpenTK.GLControl glViewport;
        private System.Windows.Forms.SplitContainer splitContainer3;
        private System.Windows.Forms.ListBox meshSetList;
        private System.Windows.Forms.ListBox modelList;
        private System.Windows.Forms.CheckBox checkBoxEnableWireframe;
        private System.Windows.Forms.CheckBox checkBoxEnableTextures;
        private System.Windows.Forms.TextBox texturePathBox;
        private System.Windows.Forms.Label modelInfo;
    }
}