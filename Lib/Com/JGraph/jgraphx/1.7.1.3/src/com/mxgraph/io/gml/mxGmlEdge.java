/**
 * $Id: mxGmlEdge.java,v 1.1 2010-09-08 14:52:50 david Exp $
 * Copyright (c) 2010 David Benson, Gaudenz Alder
 */
package com.mxgraph.io.gml;

import com.mxgraph.util.mxConstants;
import java.util.HashMap;
import java.util.Hashtable;
import java.util.List;
import org.w3c.dom.Document;
import org.w3c.dom.Element;

/**
 * Represents a Data element in the GML Structure.
 */
public class mxGmlEdge
{
	private String edgeId;

	private String edgeSource;

	private String edgeSourcePort;

	private String edgeTarget;

	private String edgeTargetPort;

	private String edgeDirected;

	private mxGmlData edgeData;

	/**
	 * Map with the data. The key is the key attribute
	 */
	private HashMap<String, mxGmlData> edgeDataMap = new HashMap<String, mxGmlData>();

	/**
	 * Construct an edge with source and target.
	 * @param edgeSource Source Node's ID.
	 * @param edgeTarget Target Node's ID.
	 */
	public mxGmlEdge(String edgeSource, String edgeTarget,
			String edgeSourcePort, String edgeTargetPort)
	{
		this.edgeId = "";
		this.edgeSource = edgeSource;
		this.edgeSourcePort = edgeSourcePort;
		this.edgeTarget = edgeTarget;
		this.edgeTargetPort = edgeTargetPort;
		this.edgeDirected = "";
	}

	/**
	 * Construct an edge from a xml edge element.
	 * @param edgeElement Xml edge element.
	 */
	public mxGmlEdge(Element edgeElement)
	{
		this.edgeId = edgeElement.getAttribute(mxGmlConstants.ID);
		this.edgeSource = edgeElement.getAttribute(mxGmlConstants.EDGE_SOURCE);
		this.edgeSourcePort = edgeElement
				.getAttribute(mxGmlConstants.EDGE_SOURCE_PORT);
		this.edgeTarget = edgeElement.getAttribute(mxGmlConstants.EDGE_TARGET);
		this.edgeTargetPort = edgeElement
				.getAttribute(mxGmlConstants.EDGE_TARGET_PORT);
		this.edgeDirected = edgeElement
				.getAttribute(mxGmlConstants.EDGE_DIRECTED);

		List<Element> dataList = mxGmlUtils.childsTags(edgeElement,
				mxGmlConstants.DATA);

		for (Element dataElem : dataList)
		{
			mxGmlData data = new mxGmlData(dataElem);
			String key = data.getDataKey();
			edgeDataMap.put(key, data);
		}
	}

	public String getEdgeDirected()
	{
		return edgeDirected;
	}

	public void setEdgeDirected(String edgeDirected)
	{
		this.edgeDirected = edgeDirected;
	}

	public String getEdgeId()
	{
		return edgeId;
	}

	public void setEdgeId(String edgeId)
	{
		this.edgeId = edgeId;
	}

	public String getEdgeSource()
	{
		return edgeSource;
	}

	public void setEdgeSource(String edgeSource)
	{
		this.edgeSource = edgeSource;
	}

	public String getEdgeSourcePort()
	{
		return edgeSourcePort;
	}

	public void setEdgeSourcePort(String edgeSourcePort)
	{
		this.edgeSourcePort = edgeSourcePort;
	}

	public String getEdgeTarget()
	{
		return edgeTarget;
	}

	public void setEdgeTarget(String edgeTarget)
	{
		this.edgeTarget = edgeTarget;
	}

	public String getEdgeTargetPort()
	{
		return edgeTargetPort;
	}

	public void setEdgeTargetPort(String edgeTargetPort)
	{
		this.edgeTargetPort = edgeTargetPort;
	}

	public HashMap<String, mxGmlData> getEdgeDataMap()
	{
		return edgeDataMap;
	}

	public void setEdgeDataMap(HashMap<String, mxGmlData> nodeEdgeMap)
	{
		this.edgeDataMap = nodeEdgeMap;
	}

	public mxGmlData getEdgeData()
	{
		return edgeData;
	}

	public void setEdgeData(mxGmlData egdeData)
	{
		this.edgeData = egdeData;
	}

	/**
	 * Generates a Edge Element from this class.
	 * @param document Document where the key Element will be inserted.
	 * @return Returns the generated Elements.
	 */
	public Element generateElement(Document document)
	{
		Element edge = document.createElement(mxGmlConstants.EDGE);
		
		if (!edgeId.equals(""))
		{
			edge.setAttribute(mxGmlConstants.ID, edgeId);
		}
		edge.setAttribute(mxGmlConstants.EDGE_SOURCE, edgeSource);
		edge.setAttribute(mxGmlConstants.EDGE_TARGET, edgeTarget);

		if (!edgeSourcePort.equals(""))
		{
			edge.setAttribute(mxGmlConstants.EDGE_SOURCE_PORT, edgeSourcePort);
		}
		
		if (!edgeTargetPort.equals(""))
		{
			edge.setAttribute(mxGmlConstants.EDGE_TARGET_PORT, edgeTargetPort);
		}
		
		if (!edgeDirected.equals(""))
		{
			edge.setAttribute(mxGmlConstants.EDGE_DIRECTED, edgeDirected);
		}

		Element dataElement = edgeData.generateEdgeElement(document);
		edge.appendChild(dataElement);

		return edge;
	}

	/**
	 * Returns if the edge has end arrow.
	 * @return style that indicates the end arrow type(CLASSIC or NONE).
	 */
	public String getEdgeStyle()
	{
		String style = "";
		Hashtable<String, Object> styleMap = new Hashtable<String, Object>();

		//Defines style of the edge.
		if (edgeDirected.equals("true"))
		{
			styleMap.put(mxConstants.STYLE_ENDARROW, mxConstants.ARROW_CLASSIC);

			style = mxGmlUtils.getStyleString(styleMap, "=");
		}
		else if (edgeDirected.equals("false"))
		{
			styleMap.put(mxConstants.STYLE_ENDARROW, mxConstants.NONE);

			style = mxGmlUtils.getStyleString(styleMap, "=");
		}

		return style;
	}
}
