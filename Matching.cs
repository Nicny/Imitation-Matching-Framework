using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using ESRI.ArcGIS.Carto;
using ESRI.ArcGIS.Controls;
using ESRI.ArcGIS.ADF;
using ESRI.ArcGIS.Display;
using ESRI.ArcGIS.DisplayUI;
using ESRI.ArcGIS.NetworkAnalyst;
using ESRI.ArcGIS.Framework;
using ESRI.ArcGIS.CartoUI;
using ESRI.ArcGIS.Geodatabase;
using ESRI.ArcGIS.Geoprocessing;
using ESRI.ArcGIS.Geoprocessor;
using ESRI.ArcGIS.DataManagementTools;
using ESRI.ArcGIS.ConversionTools;
using ESRI.ArcGIS.esriSystem;
using ESRI.ArcGIS.Geometry;
using ESRI.ArcGIS.Output;
using ESRI.ArcGIS.SystemUI;


namespace Imitation_Matching_Framework
{
    public partial class Matching : Form
    {
        #region 定义变量
        private Map m_pMaps = null;
        #endregion
        public Matching()
        {
            InitializeComponent();
            m_pMaps = new Map();
        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }

        private void 指定匹配图层ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //ICommand command = new 指定匹配图层(m_pMaps);
            ICommand command = new SpecifyDataCmd1(m_pMaps);
            command.OnCreate(axMapControl1.Object);
            command.OnClick();
        }
    }
}