using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Collections;
using System.Runtime.InteropServices;
using System.Drawing;

using ESRI.ArcGIS.Carto;
using ESRI.ArcGIS.ADF;
using ESRI.ArcGIS.Display;
using ESRI.ArcGIS.Geodatabase;
using ESRI.ArcGIS.esriSystem;

namespace Imitation_Matching_Framework
{
    public class Map : IMap , IDisposable
    {
        #region 定义变量
        
        private IRgbColor NoMatchColor;
        private IRgbColor Color_1_1;
        private IRgbColor Color_m_1;
        private IRgbColor Color_m_n;

        private Color Color1;
        private Color Color2;
        private Color Color3;
        private Color Color4;

        public ArrayList m_Array = null;
        public ArrayList m_RefLayers = null;
        public ArrayList m_TagLayers = null;
        public ArrayList RefLayers = null;
        public ArrayList TagLayers = null;

        public ArrayList InterLayer = null;
        public ArrayList BufferLayer = null;
        public ArrayList BufferLayerPt = null;

        #endregion

        #region 定义函数
        public Map()
        {
            m_Array = new ArrayList();
            m_RefLayers = new ArrayList();
            m_TagLayers = new ArrayList();
            RefLayers = new ArrayList();
            TagLayers = new ArrayList();
            InterLayer = new ArrayList();
            BufferLayer = new ArrayList();
            BufferLayerPt = new ArrayList();
        }
        #endregion

        #region 定义重置函数
        public void Reset()
        {
            m_Array.Clear();
        }

        public void RefReset()
        {
            RefLayers.Clear();
        }

        public void TagReset()
        {
            TagLayers.Clear();
        }

        public void InterReset()
        {
            InterLayer.Clear();
        }

        public void BufferReset()
        {
            BufferLayer.Clear();
        }

        public void BufferPtReset()
        {
            BufferLayerPt.Clear();
        }
        #endregion

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public ILayer ActiveGraphicsLayer
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        public void AddLayer(ILayer Layer)
        {
            throw new NotImplementedException();
        }

        public void AddLayers(IEnumLayer Layers, bool autoArrange)
        {
            throw new NotImplementedException();
        }

        public void AddMapSurround(IMapSurround MapSurround)
        {
            throw new NotImplementedException();
        }

        public IAnnotateMap AnnotationEngine
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        public ESRI.ArcGIS.Geometry.IEnvelope AreaOfInterest
        {
            set { throw new NotImplementedException(); }
        }

        public IGraphicsLayer BasicGraphicsLayer
        {
            get { throw new NotImplementedException(); }
        }

        public void ClearLayers()
        {
            throw new NotImplementedException();
        }

        public void ClearMapSurrounds()
        {
            throw new NotImplementedException();
        }

        public void ClearSelection()
        {
            throw new NotImplementedException();
        }

        public IBorder ClipBorder
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        public ESRI.ArcGIS.Geometry.IGeometry ClipGeometry
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        public double ComputeDistance(ESRI.ArcGIS.Geometry.IPoint p1, ESRI.ArcGIS.Geometry.IPoint p2)
        {
            throw new NotImplementedException();
        }

        public IMapSurround CreateMapSurround(UID clsid, IMapSurround optionalStyle)
        {
            throw new NotImplementedException();
        }

        public void DelayDrawing(bool delay)
        {
            throw new NotImplementedException();
        }

        public void DelayEvents(bool delay)
        {
            throw new NotImplementedException();
        }

        public void DeleteLayer(ILayer Layer)
        {
            throw new NotImplementedException();
        }

        public void DeleteMapSurround(IMapSurround MapSurround)
        {
            throw new NotImplementedException();
        }

        public string Description
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        public esriUnits DistanceUnits
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        public bool Expanded
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        public ISelection FeatureSelection
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        public void GetPageSize(out double widthInches, out double heightInches)
        {
            throw new NotImplementedException();
        }

        public bool IsFramed
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        public int LayerCount
        {
            get { throw new NotImplementedException(); }
        }

        public double MapScale
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        public int MapSurroundCount
        {
            get { throw new NotImplementedException(); }
        }

        public esriUnits MapUnits
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        public void MoveLayer(ILayer Layer, int toIndex)
        {
            throw new NotImplementedException();
        }

        public string Name
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        public void RecalcFullExtent()
        {
            throw new NotImplementedException();
        }

        public double ReferenceScale
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        public void SelectByShape(ESRI.ArcGIS.Geometry.IGeometry Shape, ISelectionEnvironment env, bool justOne)
        {
            throw new NotImplementedException();
        }

        public void SelectFeature(ILayer Layer, IFeature Feature)
        {
            throw new NotImplementedException();
        }

        public int SelectionCount
        {
            get { throw new NotImplementedException(); }
        }

        public void SetPageSize(double widthInches, double heightInches)
        {
            throw new NotImplementedException();
        }

        public ESRI.ArcGIS.Geometry.ISpatialReference SpatialReference
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        public bool SpatialReferenceLocked
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        public bool UseSymbolLevels
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        public IBarrierCollection get_Barriers(ESRI.ArcGIS.Geometry.IEnvelope pExtent)
        {
            throw new NotImplementedException();
        }

        public ILayer get_Layer(int Index)
        {
            throw new NotImplementedException();
        }

        public IEnumLayer get_Layers(UID uid = null, bool recursive = true)
        {
            throw new NotImplementedException();
        }

        public IMapSurround get_MapSurround(int Index)
        {
            throw new NotImplementedException();
        }
    }
}
