using System;
using System.Drawing;
using ZedGraph;
using System.Windows.Forms;
using System.Collections.Generic;

namespace OnlineNeuralNetworkTrainer
{
    public class PlotManager
    {
        private readonly string debugTAG = "[PM]";
        public int[] array_cnt;
        public List<double[]> data = new List<double[]>();
        private int window_length = 500;
        private Color[] ColorArray = new Color[] { Color.Blue, Color.Crimson,  Color.Green,  Color.Brown,
            Color.Yellow, Color.Pink, Color.Violet, Color.Wheat, Color.MediumOrchid, Color.Red,
            Color.Olive, Color.DarkGreen, Color.Goldenrod, Color.Chartreuse, Color.RoyalBlue, Color.BlueViolet
        };
        private SymbolType[] SymbolArray = new SymbolType[] { SymbolType.Circle, SymbolType.Diamond, SymbolType.Square, SymbolType.Star, SymbolType.Triangle };
        public void InitializeGraph(ZedGraphControl zedGraphControl_graph, string title, string[] legends)
        {
            SystemManager.Log(this.debugTAG, "initialising graph", false);
            array_cnt = new int[legends.Length];
            zedGraphControl_graph.GraphPane.Legend.IsVisible = true;
            zedGraphControl_graph.GraphPane.Title.Text = title;
            zedGraphControl_graph.IsEnableHZoom = true;
            zedGraphControl_graph.IsEnableVZoom = true;
            int i = 0;
            foreach (string str in legends)
            {
                PointPairList data_list = new PointPairList();
                LineItem curve = zedGraphControl_graph.GraphPane.AddCurve(str, data_list, ColorArray[i], SymbolArray[i]);
                curve.Line.IsVisible = false;
                i++;
                if (i == SymbolArray.Length)
                {
                    i = 0;
                }
            }
            zedGraphControl_graph.GraphPane.XAxis.Title.FontSpec.Size = 12.0f;
            zedGraphControl_graph.GraphPane.YAxis.Title.FontSpec.Size = 12.0f;
            zedGraphControl_graph.GraphPane.Title.FontSpec.Size = 12.0f;
            foreach (GraphPane pane in zedGraphControl_graph.MasterPane.PaneList)
                pane.IsFontsScaled = false;
        }

        public void AddData(ZedGraphControl zedGraphControl_graph, double[] xdata, double[] ydata, int idx)
        {
            try
            {
                SystemManager.Log(this.debugTAG, "adding data to plot (x,y)", false);
                // Make sure that the curvelist has at least one curve
                if (zedGraphControl_graph.GraphPane.CurveList.Count <= 0)
                    return;

                // Get the first CurveItem in the graph
                LineItem curve = zedGraphControl_graph.GraphPane.CurveList[idx] as LineItem;
                if (curve == null)
                    return;

                // Get the PointPairList
                IPointListEdit list = curve.Points as IPointListEdit;
                // If this is null, it means the reference at curve.Points does not
                // support IPointListEdit, so we won't be able to modify it
                if (list == null)
                    return;

                //list.Add(xdata, ydata);
                for (int i = 0; i < xdata.Length; i++)
                {
                    list.Add(xdata[i], ydata[i]);
                }
                // Make sure the Y axis is rescaled to accommodate actual data
                zedGraphControl_graph.AxisChange();
                // Force a redraw
                zedGraphControl_graph.Invalidate();
            }
            catch (Exception ex)
            {
                string message = ex.Message;
                if (ex.InnerException != null)
                {
                    message = ex.InnerException.Message;
                }
                SystemManager.Log(this.debugTAG, "plot failed: exception: "+ex.Message, false);
                Console.Write("[DEBUG] at PlotManager.cs, in AddData(): " + message);
                MessageBox.Show("error occurs during plotting");
            }
        }

        public void AddData(ZedGraphControl zedGraphControl_graph, double data, int idx)
        {
            try
            {
                SystemManager.Log(this.debugTAG, "adding data to plot (y)", false);
                // Make sure that the curvelist has at least one curve
                if (zedGraphControl_graph.GraphPane.CurveList.Count <= 0)
                    return;

                // Get the first CurveItem in the graph
                LineItem curve = zedGraphControl_graph.GraphPane.CurveList[idx] as LineItem;
                if (curve == null)
                    return;

                // Get the PointPairList    
                IPointListEdit list = curve.Points as IPointListEdit;
                // If this is null, it means the reference at curve.Points does not
                // support IPointListEdit, so we won't be able to modify it
                if (list == null)
                    return;

                list.Add(array_cnt[idx], data);

                // Keep the X scale at a rolling 30 second interval, with one
                // major step between the max X value and the end of the axis
                Scale xScale = zedGraphControl_graph.GraphPane.XAxis.Scale;
                if (array_cnt[idx] > xScale.Max - xScale.MajorStep)
                {
                    xScale.Max = array_cnt[idx] + xScale.MajorStep;
                    xScale.Min = xScale.Max - window_length;
                }

                array_cnt[idx]++;
                // Make sure the Y axis is rescaled to accommodate actual data
                zedGraphControl_graph.AxisChange();
                // Force a redraw
                zedGraphControl_graph.Invalidate();
            }
            catch (Exception ex)
            {
                string message = ex.Message;
                if (ex.InnerException != null)
                {
                    message = ex.InnerException.Message;
                }
                SystemManager.Log(this.debugTAG, "plot failed: exception: " + ex.Message, false);
                Console.Write("[DEBUG] at PlotManager.cs, in AddData(): " + message);
                MessageBox.Show("error occurs during plotting");
            }
        }
    }
}
