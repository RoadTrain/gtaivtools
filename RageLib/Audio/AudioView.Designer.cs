﻿/**********************************************************************\

 RageLib - Audio
 Copyright (C) 2009  Arushan/Aru <oneforaru at gmail.com>

 This program is free software: you can redistribute it and/or modify
 it under the terms of the GNU General Public License as published by
 the Free Software Foundation, either version 3 of the License, or
 (at your option) any later version.

 This program is distributed in the hope that it will be useful,
 but WITHOUT ANY WARRANTY; without even the implied warranty of
 MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
 GNU General Public License for more details.

 You should have received a copy of the GNU General Public License
 along with this program.  If not, see <http://www.gnu.org/licenses/>.

\**********************************************************************/

namespace RageLib.Audio
{
    partial class AudioView
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AudioView));
            this.listAudioBlocks = new System.Windows.Forms.ListBox();
            this.splitContainer = new System.Windows.Forms.SplitContainer();
            this.panelAudioBlock = new System.Windows.Forms.Panel();
            this.grpOptions = new System.Windows.Forms.GroupBox();
            this.chkAutoPlay = new System.Windows.Forms.CheckBox();
            this.chkPlayLooped = new System.Windows.Forms.CheckBox();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnPlay = new System.Windows.Forms.Button();
            this.tsContainer = new System.Windows.Forms.ToolStripContainer();
            this.tsToolbar = new System.Windows.Forms.ToolStrip();
            this.tsbExportWave = new System.Windows.Forms.ToolStripButton();
            this.tsbExportMultiChannel = new System.Windows.Forms.ToolStripButton();
            this.splitContainer.Panel1.SuspendLayout();
            this.splitContainer.Panel2.SuspendLayout();
            this.splitContainer.SuspendLayout();
            this.panelAudioBlock.SuspendLayout();
            this.grpOptions.SuspendLayout();
            this.tsContainer.ContentPanel.SuspendLayout();
            this.tsContainer.TopToolStripPanel.SuspendLayout();
            this.tsContainer.SuspendLayout();
            this.tsToolbar.SuspendLayout();
            this.SuspendLayout();
            // 
            // listAudioBlocks
            // 
            this.listAudioBlocks.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listAudioBlocks.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.listAudioBlocks.FormattingEnabled = true;
            this.listAudioBlocks.Location = new System.Drawing.Point(0, 0);
            this.listAudioBlocks.Name = "listAudioBlocks";
            this.listAudioBlocks.Size = new System.Drawing.Size(184, 436);
            this.listAudioBlocks.TabIndex = 0;
            this.listAudioBlocks.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.listAudioBlocks_DrawItem);
            this.listAudioBlocks.MeasureItem += new System.Windows.Forms.MeasureItemEventHandler(this.listAudioBlocks_MeasureItem);
            // 
            // splitContainer
            // 
            this.splitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer.Location = new System.Drawing.Point(0, 0);
            this.splitContainer.Name = "splitContainer";
            // 
            // splitContainer.Panel1
            // 
            this.splitContainer.Panel1.Controls.Add(this.listAudioBlocks);
            // 
            // splitContainer.Panel2
            // 
            this.splitContainer.Panel2.Controls.Add(this.panelAudioBlock);
            this.splitContainer.Size = new System.Drawing.Size(619, 436);
            this.splitContainer.SplitterDistance = 184;
            this.splitContainer.TabIndex = 1;
            // 
            // panelAudioBlock
            // 
            this.panelAudioBlock.Controls.Add(this.grpOptions);
            this.panelAudioBlock.Controls.Add(this.btnStop);
            this.panelAudioBlock.Controls.Add(this.btnPlay);
            this.panelAudioBlock.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelAudioBlock.Location = new System.Drawing.Point(0, 0);
            this.panelAudioBlock.Name = "panelAudioBlock";
            this.panelAudioBlock.Size = new System.Drawing.Size(431, 436);
            this.panelAudioBlock.TabIndex = 0;
            // 
            // grpOptions
            // 
            this.grpOptions.Controls.Add(this.chkAutoPlay);
            this.grpOptions.Controls.Add(this.chkPlayLooped);
            this.grpOptions.Location = new System.Drawing.Point(12, 57);
            this.grpOptions.Name = "grpOptions";
            this.grpOptions.Size = new System.Drawing.Size(236, 67);
            this.grpOptions.TabIndex = 5;
            this.grpOptions.TabStop = false;
            this.grpOptions.Text = "Options";
            // 
            // chkAutoPlay
            // 
            this.chkAutoPlay.AutoSize = true;
            this.chkAutoPlay.Location = new System.Drawing.Point(9, 19);
            this.chkAutoPlay.Name = "chkAutoPlay";
            this.chkAutoPlay.Size = new System.Drawing.Size(121, 17);
            this.chkAutoPlay.TabIndex = 3;
            this.chkAutoPlay.Text = "Auto Play On Select";
            this.chkAutoPlay.UseVisualStyleBackColor = true;
            // 
            // chkPlayLooped
            // 
            this.chkPlayLooped.AutoSize = true;
            this.chkPlayLooped.Location = new System.Drawing.Point(9, 42);
            this.chkPlayLooped.Name = "chkPlayLooped";
            this.chkPlayLooped.Size = new System.Drawing.Size(85, 17);
            this.chkPlayLooped.TabIndex = 4;
            this.chkPlayLooped.Text = "Play Looped";
            this.chkPlayLooped.UseVisualStyleBackColor = true;
            // 
            // btnStop
            // 
            this.btnStop.Image = ((System.Drawing.Image)(resources.GetObject("btnStop.Image")));
            this.btnStop.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnStop.Location = new System.Drawing.Point(84, 14);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(66, 32);
            this.btnStop.TabIndex = 1;
            this.btnStop.Text = "Stop";
            this.btnStop.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnStop.UseVisualStyleBackColor = true;
            // 
            // btnPlay
            // 
            this.btnPlay.Image = ((System.Drawing.Image)(resources.GetObject("btnPlay.Image")));
            this.btnPlay.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPlay.Location = new System.Drawing.Point(12, 14);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(66, 32);
            this.btnPlay.TabIndex = 0;
            this.btnPlay.Text = "Play";
            this.btnPlay.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPlay.UseVisualStyleBackColor = true;
            // 
            // tsContainer
            // 
            // 
            // tsContainer.ContentPanel
            // 
            this.tsContainer.ContentPanel.Controls.Add(this.splitContainer);
            this.tsContainer.ContentPanel.Size = new System.Drawing.Size(619, 436);
            this.tsContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tsContainer.Location = new System.Drawing.Point(0, 0);
            this.tsContainer.Name = "tsContainer";
            this.tsContainer.Size = new System.Drawing.Size(619, 461);
            this.tsContainer.TabIndex = 2;
            this.tsContainer.Text = "toolStripContainer1";
            // 
            // tsContainer.TopToolStripPanel
            // 
            this.tsContainer.TopToolStripPanel.Controls.Add(this.tsToolbar);
            // 
            // tsToolbar
            // 
            this.tsToolbar.Dock = System.Windows.Forms.DockStyle.None;
            this.tsToolbar.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.tsToolbar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbExportWave,
            this.tsbExportMultiChannel});
            this.tsToolbar.Location = new System.Drawing.Point(0, 0);
            this.tsToolbar.Name = "tsToolbar";
            this.tsToolbar.Size = new System.Drawing.Size(619, 25);
            this.tsToolbar.Stretch = true;
            this.tsToolbar.TabIndex = 0;
            // 
            // tsbExportWave
            // 
            this.tsbExportWave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbExportWave.Image = ((System.Drawing.Image)(resources.GetObject("tsbExportWave.Image")));
            this.tsbExportWave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbExportWave.Name = "tsbExportWave";
            this.tsbExportWave.Size = new System.Drawing.Size(120, 22);
            this.tsbExportWave.Text = "Export Selected WAV";
            // 
            // tsbExportMultiChannel
            // 
            this.tsbExportMultiChannel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbExportMultiChannel.Image = ((System.Drawing.Image)(resources.GetObject("tsbExportMultiChannel.Image")));
            this.tsbExportMultiChannel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbExportMultiChannel.Name = "tsbExportMultiChannel";
            this.tsbExportMultiChannel.Size = new System.Drawing.Size(146, 22);
            this.tsbExportMultiChannel.Text = "Export Multichannel WAV";
            // 
            // AudioView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tsContainer);
            this.Name = "AudioView";
            this.Size = new System.Drawing.Size(619, 461);
            this.splitContainer.Panel1.ResumeLayout(false);
            this.splitContainer.Panel2.ResumeLayout(false);
            this.splitContainer.ResumeLayout(false);
            this.panelAudioBlock.ResumeLayout(false);
            this.grpOptions.ResumeLayout(false);
            this.grpOptions.PerformLayout();
            this.tsContainer.ContentPanel.ResumeLayout(false);
            this.tsContainer.TopToolStripPanel.ResumeLayout(false);
            this.tsContainer.TopToolStripPanel.PerformLayout();
            this.tsContainer.ResumeLayout(false);
            this.tsContainer.PerformLayout();
            this.tsToolbar.ResumeLayout(false);
            this.tsToolbar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listAudioBlocks;
        private System.Windows.Forms.SplitContainer splitContainer;
        private System.Windows.Forms.Panel panelAudioBlock;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.CheckBox chkPlayLooped;
        private System.Windows.Forms.CheckBox chkAutoPlay;
        private System.Windows.Forms.ToolStripContainer tsContainer;
        private System.Windows.Forms.ToolStrip tsToolbar;
        private System.Windows.Forms.ToolStripButton tsbExportWave;
        private System.Windows.Forms.ToolStripButton tsbExportMultiChannel;
        private System.Windows.Forms.GroupBox grpOptions;
    }
}
