/**
 * $Id: mxGmlNode.java,v 1.1 2010-09-08 14:52:50 david Exp $
 * Copyright (c) 2010 David Benson, Gaudenz Alder
 */
package com.mxgraph.io.gml;

import java.util.ArrayList;
import java.util.HashMap;
import java.util.List;
import org.w3c.dom.Document;
import org.w3c.dom.Element;

/**
 * Represents a Data element in the GML Structure.
 */
public class mxGmlNode
{
	private String nodeId;

	private mxGmlData nodeData;

	private List<mxGmlGraph> nodeGraphList = new ArrayList<mxGmlGraph>();

	private HashMap<String, mxGmlData> nodeDataMap = new HashMap<String, mxGmlData>();

	private HashMap<String, mxGmlPort> nodePortMap = new HashMap<String, mxGmlPort>();

	/**
	 * Construct a node with Id and one data element
	 * @param nodeId Node`s ID
	 * @param nodeData Gml Data.
	 */
	public mxGmlNode(String nodeId, mxGmlData nodeData)
	{
		this.nodeId = nodeId;
		this.nodeData = nodeData;
	}

	/**
	 * Construct a Node from a xml Node Element.
	 * @param nodeElement Xml Node Element.
	 */
	public mxGmlNode(Element nodeElement)
	{
		this.nodeId = nodeElement.getAttribute(mxGmlConstants.ID);

		//Add data elements
		List<Element> dataList = mxGmlUtils.childsTags(nodeElement,
				mxGmlConstants.DATA);

		for (Element dataElem : dataList)
		{
			mxGmlData data = new mxGmlData(dataElem);
			String key = data.getDataKey();
			nodeDataMap.put(key, data);
		}

		//Add graph elements
		List<Element> graphList = mxGmlUtils.childsTags(nodeElement,
				mxGmlConstants.GRAPH);

		for (Element graphElem : graphList)
		{
			mxGmlGraph graph = new mxGmlGraph(graphElem);
			nodeGraphList.add(graph);
		}

		//Add port elements
		List<Element> portList = mxGmlUtils.childsTags(nodeElement,
				mxGmlConstants.PORT);

		for (Element portElem : portList)
		{
			mxGmlPort port = new mxGmlPort(portElem);
			String name = port.getName();
			nodePortMap.put(name, port);
		}
	}

	public String getNodeId()
	{
		return nodeId;
	}

	public void setNodeId(String nodeId)
	{
		this.nodeId = nodeId;
	}

	public HashMap<String, mxGmlData> getNodeDataMap()
	{
		return nodeDataMap;
	}

	public void setNodeDataMap(HashMap<String, mxGmlData> nodeDataMap)
	{
		this.nodeDataMap = nodeDataMap;
	}

	public List<mxGmlGraph> getNodeGraph()
	{
		return nodeGraphList;
	}

	public void setNodeGraph(List<mxGmlGraph> nodeGraph)
	{
		this.nodeGraphList = nodeGraph;
	}

	public HashMap<String, mxGmlPort> getNodePort()
	{
		return nodePortMap;
	}

	public void setNodePort(HashMap<String, mxGmlPort> nodePort)
	{
		this.nodePortMap = nodePort;
	}

	/**
	 * Generates a Key Element from this class.
	 * @param document Document where the key Element will be inserted.
	 * @return Returns the generated Elements.
	 */
	public Element generateElement(Document document)
	{
		Element node = document.createElement(mxGmlConstants.NODE);

		node.setAttribute(mxGmlConstants.ID, nodeId);

		Element dataElement = nodeData.generateNodeElement(document);
		node.appendChild(dataElement);

		for (mxGmlPort port : nodePortMap.values())
		{
			Element portElement = port.generateElement(document);
			node.appendChild(portElement);
		}

		for (mxGmlGraph graph : nodeGraphList)
		{
			Element graphElement = graph.generateElement(document);
			node.appendChild(graphElement);
		}

		return node;
	}

	public mxGmlData getNodeData()
	{
		return nodeData;
	}

	public void setNodeData(mxGmlData nodeData)
	{
		this.nodeData = nodeData;
	}

}
