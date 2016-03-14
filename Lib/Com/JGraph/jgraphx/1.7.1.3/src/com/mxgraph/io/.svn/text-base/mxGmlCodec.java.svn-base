/**
 * $Id: mxGmlCodec.java,v 1.2 2010-10-21 13:15:40 david Exp $
 * Copyright (c) 2010 David Benson, Gaudenz Alder
 */
package com.mxgraph.io;

import com.mxgraph.io.gml.mxGmlConstants;
import com.mxgraph.io.gml.mxGmlData;
import com.mxgraph.io.gml.mxGmlEdge;
import com.mxgraph.io.gml.mxGmlGraph;
import com.mxgraph.io.gml.mxGmlKey;
import com.mxgraph.io.gml.mxGmlKeyManager;
import com.mxgraph.io.gml.mxGmlNode;
import com.mxgraph.io.gml.mxGmlShapeEdge;
import com.mxgraph.io.gml.mxGmlShapeNode;
import com.mxgraph.io.gml.mxGmlUtils;
import com.mxgraph.model.mxCell;
import com.mxgraph.util.mxConstants;
import com.mxgraph.util.mxPoint;
import com.mxgraph.util.mxUtils;
import com.mxgraph.view.mxCellState;
import com.mxgraph.view.mxConnectionConstraint;

import com.mxgraph.view.mxGraph;
import com.mxgraph.view.mxGraphView;
import java.util.HashMap;
import java.util.List;
import org.w3c.dom.Document;
import org.w3c.dom.Element;
import org.w3c.dom.NodeList;

/**
 * Parses a GraphML .graphml file and imports it in the given graph.<br/>
 * This class depends from the classes contained in
 * com.mxgraph.io.gmlImplements.
 */
public class mxGmlCodec
{
	/**
	 * Receives a GraphMl document and parses it generating a new graph that is inserted in graph.
	 * @param document XML to be parsed
	 * @param graph Graph where the parsed graph is included.
	 */
	public static void decode(Document document, mxGraph graph)
	{
		Object parent = graph.getDefaultParent();

		graph.getModel().beginUpdate();

		// Initialise the key properties.
		mxGmlKeyManager.getInstance().initialise(document);

		NodeList graphs = document.getElementsByTagName(mxGmlConstants.GRAPH);
		if (graphs.getLength() > 0)
		{

			Element graphElement = (Element) graphs.item(0);

			//Create the graph model.
			mxGmlGraph gmlGraph = new mxGmlGraph(graphElement);

			gmlGraph.addGraph(graph, parent);
		}

		graph.getModel().endUpdate();
		cleanMaps();
	}

	/**
	 * Remove all the elements in the Defined Maps.
	 */
	private static void cleanMaps()
	{
		mxGmlKeyManager.getInstance().getKeyMap().clear();
	}

	/**
	 * Generates a Xml document with the gmlGraph.
	 * @param gmlGraph Graph model.
	 * @return The Xml document generated.
	 */
	public static Document encodeXML(mxGmlGraph gmlGraph)
	{
		Document doc = mxUtils.createDocument();

		Element graphml = doc.createElement(mxGmlConstants.GRAPHML);

		graphml.setAttribute("xmlns", "http://graphml.graphdrawing.org/xmlns");
		graphml.setAttributeNS("http://www.w3.org/2000/xmlns/", "xmlns:xsi",
				"http://www.w3.org/2001/XMLSchema-instance");
		graphml.setAttributeNS("http://www.w3.org/2000/xmlns/", "xmlns:jGraph",
				mxGmlConstants.JGRAPH_URL);
		graphml.setAttributeNS(
				"http://www.w3.org/2001/XMLSchema-instance",
				"xsi:schemaLocation",
				"http://graphml.graphdrawing.org/xmlns http://graphml.graphdrawing.org/xmlns/1.0/graphml.xsd");

		HashMap<String, mxGmlKey> keyMap = mxGmlKeyManager.getInstance()
				.getKeyMap();

		for (mxGmlKey key : keyMap.values())
		{
			Element keyElement = key.generateElement(doc);
			graphml.appendChild(keyElement);
		}

		Element graphE = gmlGraph.generateElement(doc);
		graphml.appendChild(graphE);

		doc.appendChild(graphml);
		cleanMaps();
		return doc;

	}

	/**
	 * Generates a Xml document with the cells in the graph.
	 * @param graph Graph with the cells.
	 * @return The Xml document generated.
	 */
	public static Document encode(mxGraph graph)
	{
		mxGmlGraph gmlGraph = new mxGmlGraph();
		Object parent = graph.getDefaultParent();

		createKeyElements();

		gmlGraph = decodeGraph(graph, parent, gmlGraph);
		gmlGraph.setEdgedefault(mxGmlConstants.EDGE_DIRECTED);

		Document document = encodeXML(gmlGraph);

		return document;
	}

	/**
	 * Creates the key elements for the encode.
	 */
	private static void createKeyElements()
	{
		HashMap<String, mxGmlKey> keyMap = mxGmlKeyManager.getInstance()
				.getKeyMap();
		mxGmlKey keyNode = new mxGmlKey(mxGmlConstants.KEY_NODE_ID,
				mxGmlKey.keyForValues.NODE, mxGmlConstants.KEY_NODE_NAME,
				mxGmlKey.keyTypeValues.STRING);
		keyMap.put(mxGmlConstants.KEY_NODE_ID, keyNode);
		mxGmlKey keyEdge = new mxGmlKey(mxGmlConstants.KEY_EDGE_ID,
				mxGmlKey.keyForValues.EDGE, mxGmlConstants.KEY_EDGE_NAME,
				mxGmlKey.keyTypeValues.STRING);
		keyMap.put(mxGmlConstants.KEY_EDGE_ID, keyEdge);
		mxGmlKeyManager.getInstance().setKeyMap(keyMap);
	}

	/**
	 * Returns a Gml graph with the data of the vertexes and edges in the graph.
	 * @param gmlGraph Gml document where the elements are put.
	 * @param parent Parent cell of the vertexes and edges to be added.
	 * @param graph Graph that contains the vertexes and edges.
	 * @return Returns the document with the elements added.
	 */
	public static mxGmlGraph decodeGraph(mxGraph graph, Object parent,
			mxGmlGraph gmlGraph)
	{
		Object[] vertexes = graph.getChildVertices(parent);
		List<mxGmlEdge> gmlEdges = gmlGraph.getEdges();
		gmlEdges = encodeEdges(gmlEdges, parent, graph);
		gmlGraph.setEdges(gmlEdges);

		for (Object vertex : vertexes)
		{
			List<mxGmlNode> Gmlnodes = gmlGraph.getNodes();

			mxCell v = (mxCell) vertex;
			String id = v.getId();

			mxGmlNode gmlNode = new mxGmlNode(id, null);
			addNodeData(gmlNode, v);
			Gmlnodes.add(gmlNode);
			gmlGraph.setNodes(Gmlnodes);
			mxGmlGraph gmlGraphx = new mxGmlGraph();

			gmlGraphx = decodeGraph(graph, vertex, gmlGraphx);

			if (!gmlGraphx.isEmpty())
			{
				List<mxGmlGraph> nodeGraphs = gmlNode.getNodeGraph();
				nodeGraphs.add(gmlGraphx);
				gmlNode.setNodeGraph(nodeGraphs);
			}
		}

		return gmlGraph;
	}

	/**
	 * Add the node data in the gmlNode.
	 * @param gmlNode Gml node where the data add.
	 * @param v mxCell where data are obtained.
	 */
	public static void addNodeData(mxGmlNode gmlNode, mxCell v)
	{
		mxGmlData data = new mxGmlData();
		mxGmlShapeNode dataShapeNode = new mxGmlShapeNode();

		data.setDataKey(mxGmlConstants.KEY_NODE_ID);
		dataShapeNode
				.setDataHeight(String.valueOf(v.getGeometry().getHeight()));
		dataShapeNode.setDataWidth(String.valueOf(v.getGeometry().getWidth()));
		dataShapeNode.setDataX(String.valueOf(v.getGeometry().getX()));
		dataShapeNode.setDataY(String.valueOf(v.getGeometry().getY()));
		dataShapeNode.setDataLabel(v.getValue() != null ? v.getValue()
				.toString() : "");
		dataShapeNode.setDataStyle(v.getStyle() != null ? v.getStyle() : "");

		data.setDataShapeNode(dataShapeNode);
		gmlNode.setNodeData(data);
	}

	/**
	 * Add the edge data in the gmlEdge.
	 * @param gmlEdge Gml edge where the data add.
	 * @param v mxCell where data are obtained.
	 */
	public static void addEdgeData(mxGmlEdge gmlEdge, mxCell v)
	{
		mxGmlData data = new mxGmlData();
		mxGmlShapeEdge dataShapeEdge = new mxGmlShapeEdge();

		data.setDataKey(mxGmlConstants.KEY_EDGE_ID);
		dataShapeEdge.setText(v.getValue() != null ? v.getValue().toString()
				: "");
		dataShapeEdge.setStyle(v.getStyle() != null ? v.getStyle() : "");

		data.setDataShapeEdge(dataShapeEdge);
		gmlEdge.setEdgeData(data);
	}

	/**
	 * Converts a connection point in the string representation of a port.
	 * The specials names North, NorthWest, NorthEast, East, West, South, SouthEast and SouthWest
	 * may be returned. Else, the values returned follows the pattern "double,double"
	 * where double must be in the range 0..1
	 * @param point mxPoint
	 * @return Name of the port
	 */
	private static String pointToPortString(mxPoint point)
	{
		String port = "";
		if (point != null)
		{
			double x = point.getX();
			double y = point.getY();

			if (x == 0 && y == 0)
			{
				port = "NorthWest";
			}
			else if (x == 0.5 && y == 0)
			{
				port = "North";
			}
			else if (x == 1 && y == 0)
			{
				port = "NorthEast";
			}
			else if (x == 1 && y == 0.5)
			{
				port = "East";
			}
			else if (x == 1 && y == 1)
			{
				port = "SouthEast";
			}
			else if (x == 0.5 && y == 1)
			{
				port = "South";
			}
			else if (x == 0 && y == 1)
			{
				port = "SouthWest";
			}
			else if (x == 0 && y == 0.5)
			{
				port = "West";
			}
			else
			{
				port = "" + x + "," + y;
			}
		}
		return port;
	}

	/**
	 * Returns a list of mxGmlEdge with the data of the edges in the graph.
	 * @param Gmledges List where the elements are put.
	 * @param parent Parent cell of the edges to be added.
	 * @param graph Graph that contains the edges.
	 * @return Returns the list Gmledges with the elements added.
	 */
	private static List<mxGmlEdge> encodeEdges(List<mxGmlEdge> Gmledges,
			Object parent, mxGraph graph)
	{
		Object[] edges = graph.getChildEdges(parent);
		for (Object edge : edges)
		{
			mxCell e = (mxCell) edge;
			mxCell source = (mxCell) e.getSource();
			mxCell target = (mxCell) e.getTarget();

			String sourceName = "";
			String targetName = "";
			String sourcePort = "";
			String targetPort = "";
			sourceName = source != null ? source.getId() : "";
			targetName = target != null ? target.getId() : "";

			//Get the graph view that contains the states
			mxGraphView view = graph.getView();
			mxPoint sourceConstraint = null;
			mxPoint targetConstraint = null;
			if (view != null)
			{
				mxCellState edgeState = view.getState(edge);
				mxCellState sourceState = view.getState(source);
				mxConnectionConstraint scc = graph.getConnectionConstraint(
						edgeState, sourceState, true);
				if (scc != null)
				{
					sourceConstraint = scc.getPoint();
				}

				mxCellState targetState = view.getState(target);
				mxConnectionConstraint tcc = graph.getConnectionConstraint(
						edgeState, targetState, false);
				if (tcc != null)
				{
					targetConstraint = tcc.getPoint();
				}
			}

			//gets the port names
			targetPort = pointToPortString(targetConstraint);
			sourcePort = pointToPortString(sourceConstraint);

			mxGmlEdge Gmledge = new mxGmlEdge(sourceName, targetName,
					sourcePort, targetPort);

			String style = e.getStyle();

			if (style == null)
			{
				style = "horizontal";

			}

			HashMap<String, Object> styleMap = mxGmlUtils.getStyleMap(style,
					"=");
			String endArrow = (String) styleMap.get(mxConstants.STYLE_ENDARROW);
			if ((endArrow != null && !endArrow.equals(mxConstants.NONE))
					|| endArrow == null)
			{
				Gmledge.setEdgeDirected("true");
			}
			else
			{
				Gmledge.setEdgeDirected("false");
			}
			addEdgeData(Gmledge, e);
			Gmledges.add(Gmledge);
		}

		return Gmledges;
	}
}
