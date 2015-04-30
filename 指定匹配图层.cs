using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using ESRI.ArcGIS.Controls;
using ESRI.ArcGIS.Carto;

namespace Imitation_Matching_Framework
{
    public partial class 指定匹配图层 : Form
    {
        #region 定义变量
        Map m_pMaps;
        IMapControl3 m_mapControl;
        #endregion
        public 指定匹配图层(IMapControl3 m_mapcontrol, Map pMaps)
        {
            m_pMaps = pMaps;
            m_mapControl = m_mapcontrol;
            InitializeComponent();
        }

        private void 指定匹配图层_Load(object sender, EventArgs e)
        {
            string LayerName;
            IFeatureLayer pFeatureLayer;
            for (int i = 0; i < m_mapControl.LayerCount; i++)
            {
                pFeatureLayer = m_mapControl.get_Layer(i) as IFeatureLayer;
                LayerName = pFeatureLayer.Name;
                checkedListBox1.Items.Add(LayerName);
                checkedListBox2.Items.Add(LayerName);
            }
        }
    }
}
