/**
 * $Id: mxGmlGraph.java,v 1.1 2010-09-08 14:52:50 david Exp $
 * Copyright (c) 2010 David Benson, Gaudenz Alder
 */
package com.mxgraph.io.gml;

import com.mxgraph.model.mxCell;
import com.mxgraph.util.mxPoint;
import com.mxgraph.view.mxConnectionConstraint;
import com.mxgraph.view.mxGraph;
import java.util.ArrayList;
import java.util.HashMap;
import java.util.List;
import org.w3c.dom.Document;
import org.w3c.dom.Element;

/**
 * Represents a Graph element in the GML Structure.
 */
public class mxGmlGraph
{
	/**
	 * Map with the vertex cells added in the addNode method.
	 */
	private static HashMap<String, Object> cellsMap = new HashMap<String, Object>();

	private String id = "";

	private String edgedefault = "";

	private List<mxGmlNode> nodes = new ArrayList<mxGmlNode>();

	private List<mxGmlEdge> edges = new ArrayList<mxGmlEdge>();

	/**
	 * Constructs a graph with id and edge default direction.
	 * @param id Graph's ID
	 * @param edgedefault Edge Default direction.("directed" or "undirected")
	 */
	public mxGmlGraph(String id, String edgedefault)
	{
		this.id = id;
		this.edgedefault = edgedefault;
	}

	/**
	 * Constructs an empty graph.
	 */
	public mxGmlGraph()
	{
	}

	/**
	 * Constructs a graph from a xml graph element.
	 * @param graphElement Xml graph element.
	 */
	public mxGmlGraph(Element graphElement)
	{
		this.id = graphElement.getAttribute(mxGmlConstants.ID);
		this.edgedefault = graphElement
				.getAttribute(mxGmlConstants.EDGE_DEFAULT);

		//Adds node elements
		List<Element> nodeElements = mxGmlUtils.childsTags(graphElement,
				mxGmlConstants.NODE);

		for (Element nodeElem : nodeElements)
		{
			mxGmlNode node = new mxGmlNode(nodeElem);

			nodes.add(node);
		}

		//Adds edge elements
		List<Element> edgeElements = mxGmlUtils.childsTags(graphElement,
				mxGmlConstants.EDGE);

		for (Element edgeElem : edgeElements)
		{
			mxGmlEdge edge = new mxGmlEdge(edgeElem);

			if (edge.getEdgeDirected().equals(""))
			{
				if (edgedefault.equals(mxGmlConstants.EDGE_DIRECTED))
				{
					edge.setEdgeDirected("true");
				}
				else if (edgedefault.equals(mxGmlConstants.EDGE_UNDIRECTED))
				{
					edge.setEdgeDirected("false");
				}
			}

			edges.add(edge);
		}
	}

	/**
	 * Adds the elements represented for this graph model into the given graph.
	 * @param graph Graph where the elements will be located
	 * @param parent Parent of the cells to be added.
	 */
	public void addGraph(mxGraph graph, Object parent)
	{
		List<mxGmlNode> nodeList = getNodes();

		for (mxGmlNode node : nodeList)
		{
			addNode(graph, parent, node);
		}
		List<mxGmlEdge> edgeList = getEdges();

		for (mxGmlEdge edge : edgeList)
		{
			addEdge(graph, parent, edge);
		}
	}

	/**
	 * Checks if the node has data elements inside.
	 * @param node Gml node element.
	 * @return Returns <code>true</code> if the node has data elements inside.
	 */
	public static boolean hasData(mxGmlNode node)
	{
		boolean ret = false;
		if (node.getNodeDataMap() == null)
		{
			ret = false;
		}
		else
		{
			ret = true;
		}
		return ret;
	}

	/**
	 * Returns the data element inside the node that references to the key element
	 * with name = KEY_NODE_NAME.
	 * @param node Gml Node element.
	 * @return The required data. null if not found.
	 */
	public static mxGmlData dataNodeKey(mxGmlNode node)
	{
		String keyId = "";
		HashMap<String, mxGmlKey> keyMap = mxGmlKeyManager.getInstance()
				.getKeyMap();
		
		for (mxGmlKey key : keyMap.values())
		{
			if (key.getKeyName().equals(mxGmlConstants.KEY_NODE_NAME))
			{
				keyId = key.getKeyId();
			}
		}

		mxGmlData data = null;
		HashMap<String, mxGmlData> nodeDataMap = node.getNodeDataMap();
		data = nodeDataMap.get(keyId);

		return data;
	}

	/**
	 * Returns the data element inside the edge that references to the key element
	 * with name = KEY_EDGE_NAME.
	 * @param edge Gml Edge element.
	 * @return The required data. null if not found.
	 */
	public static mxGmlData dataEdgeKey(mxGmlEdge edge)
	{
		String keyId = "";
		HashMap<String, mxGmlKey> keyMap = mxGmlKeyManager.getInstance()
				.getKeyMap();
		for (mxGmlKey key : keyMap.values())
		{
			if (key.getKeyName().equals(mxGmlConstants.KEY_EDGE_NAME))
			{
				keyId = key.getKeyId();
			}
		}

		mxGmlData data = null;
		HashMap<String, mxGmlData> nodeDataMap = edge.getEdgeDataMap();
		data = nodeDataMap.get(keyId);

		return data;
	}

	/**
	 * Adds the vertex represented for the gml node into the graph with the given parent.
	 * @param graph Graph where the vertex will be added.
	 * @param parent Parent's cell.
	 * @param node Gml Node
	 * @return The inserted Vertex cell.
	 */
	private mxCell addNode(mxGraph graph, Object parent, mxGmlNode node)
	{
		mxCell v1;
		String id = node.getNodeId();

		mxGmlData data = dataNodeKey(node);

		if (data != null && data.getDataShapeNode() != null)
		{
			Double x = Double.valueOf(data.getDataShapeNode().getDataX());
			Double y = Double.valueOf(data.getDataShapeNode().getDataY());
			Double h = Double.valueOf(data.getDataShapeNode().getDataHeight());
			Double w = Double.valueOf(data.getDataShapeNode().getDataWidth());
			String label = data.getDataShapeNode().getDataLabel();
			String style = data.getDataShapeNode().getDataStyle();
			v1 = (mxCell) graph.insertVertex(parent, id, label, x, y, w, h,
					style);
		}
		else
		{
			v1 = (mxCell) graph.insertVertex(parent, id, "", 0, 0, 100, 100);
		}

		cellsMap.put(id, v1);
		List<mxGmlGraph> graphs = node.getNodeGraph();

		for (mxGmlGraph gmlGraph : graphs)
		{
			gmlGraph.addGraph(graph, v1);
		}
		return v1;
	}

	/**
	 * Returns the point represented for the port name.
	 * The specials names North, NorthWest, NorthEast, East, West, South, SouthEast and SouthWest.
	 * are accepted. Else, the values acepted follow the pattern "double,double".
	 * where double must be in the range 0..1
	 * @param source Port Name.
	 * @return point that represent the port value.
	 */
	private static mxPoint portValue(String source)
	{
		mxPoint fromConstraint = null;

		if (source != null && !source.equals(""))
		{

			if (source.equals("North"))
			{
				fromConstraint = new mxPoint(0.5, 0);
			}
			else if (source.equals("South"))
			{
				fromConstraint = new mxPoint(0.5, 1);

			}
			else if (source.equals("East"))
			{
				fromConstraint = new mxPoint(1, 0.5);

			}
			else if (source.equals("West"))
			{
				fromConstraint = new mxPoint(0, 0.5);

			}
			else if (source.equals("NorthWest"))
			{
				fromConstraint = new mxPoint(0, 0);
			}
			else if (source.equals("SouthWest"))
			{
				fromConstraint = new mxPoint(0, 1);
			}
			else if (source.equals("SouthEast"))
			{
				fromConstraint = new mxPoint(1, 1);
			}
			else if (source.equals("NorthEast"))
			{
				fromConstraint = new mxPoint(1, 0);
			}
			else
			{
				try
				{
					String[] s = source.split(",");
					Double x = Double.valueOf(s[0]);
					Double y = Double.valueOf(s[1]);
					fromConstraint = new mxPoint(x, y);
				}
				catch (Exception e)
				{
					e.printStackTrace();
				}
			}
		}
		return fromConstraint;
	}

	/**
	 * Adds the edge represented for the gml edge into the graph with the given parent.
	 * @param graph Graph where the vertex will be added.
	 * @param parent Parent's cell.
	 * @param edge Gml Edge
	 * @return The inserted edge cell.
	 */
	private static mxCell addEdge(mxGraph graph, Object parent, mxGmlEdge edge)
	{
		//Get source and target vertex
		mxPoint fromConstraint = null;
		mxPoint toConstraint = null;
		Object source = cellsMap.get(edge.getEdgeSource());
		Object target = cellsMap.get(edge.getEdgeTarget());
		String sourcePort = edge.getEdgeSourcePort();
		String targetPort = edge.getEdgeTargetPort();

		fromConstraint = portValue(sourcePort);

		toConstraint = portValue(targetPort);

		mxGmlData data = dataEdgeKey(edge);

		String style = "";
		String label = "";

		if (data != null)
		{
			mxGmlShapeEdge shEdge = data.getDataShapeEdge();
			style = shEdge.getStyle();
			label = shEdge.getText();
		}
		else
		{
			style = edge.getEdgeStyle();
		}

		//Insert new edge.
		mxCell e = (mxCell) graph.insertEdge(parent, null, label, source,
				target, style);
		graph.setConnectionConstraint(e, source, true,
				new mxConnectionConstraint(fromConstraint, false));
		graph.setConnectionConstraint(e, target, false,
				new mxConnectionConstraint(toConstraint, false));
		return e;
	}

	public String getEdgedefault()
	{
		return edgedefault;
	}

	public void setEdgedefault(String edgedefault)
	{
		this.edgedefault = edgedefault;
	}

	public String getId()
	{
		return id;
	}

	public void setId(String id)
	{
		this.id = id;
	}

	public List<mxGmlNode> getNodes()
	{
		return nodes;
	}

	public void setNodes(List<mxGmlNode> node)
	{
		this.nodes = node;
	}

	public List<mxGmlEdge> getEdges()
	{
		return edges;
	}

	public void setEdges(List<mxGmlEdge> edge)
	{
		this.edges = edge;
	}

	/**
	 * Checks if the graph has child nodes or edges.
	 * @return Returns <code>true</code> if the graph hasn't child nodes or edges.
	 */
	public boolean isEmpty()
	{
		return nodes.size() == 0 && edges.size() == 0;
	}

	/**
	 * Generates a Key Element from this class.
	 * @param document Document where the key Element will be inserted.
	 * @return Returns the generated Elements.
	 */
	public Element generateElement(Document document)
	{
		Element graph = document.createElement(mxGmlConstants.GRAPH);

		if (!id.equals(""))
		{
			graph.setAttribute(mxGmlConstants.ID, id);
		}
		if (!edgedefault.equals(""))
		{
			graph.setAttribute(mxGmlConstants.EDGE_DEFAULT, edgedefault);
		}

		for (mxGmlNode node : nodes)
		{
			Element nodeElement = node.generateElement(document);
			graph.appendChild(nodeElement);
		}

		for (mxGmlEdge edge : edges)
		{
			Element edgeElement = edge.generateElement(document);
			graph.appendChild(edgeElement);
		}

		return graph;
	}
}
