/**
 * $Id: mxGmlData.java,v 1.1 2010-09-08 14:52:50 david Exp $
 * Copyright (c) 2010 David Benson, Gaudenz Alder
 */
package com.mxgraph.io.gml;

import java.util.List;
import org.w3c.dom.Document;
import org.w3c.dom.Element;
import org.w3c.dom.Node;
import org.w3c.dom.NodeList;

/**
 * Represents a Data element in the GML Structure.
 */
public class mxGmlData
{
	private String dataId = "";

	private String dataKey = "";

	private String dataValue = "";//not using

	private mxGmlShapeNode dataShapeNode;

	private mxGmlShapeEdge dataShapeEdge;

	/**
	 * Construct a data with the params values.
	 * @param dataId Data's ID
	 * @param dataKey Reference to a Key Element ID
	 * @param dataValue Value of the data Element
	 * @param dataShapeEdge JGraph specific edge properties.
	 * @param dataShapeNode JGraph specific node properties.
	 */
	public mxGmlData(String dataId, String dataKey, String dataValue,
			mxGmlShapeEdge dataShapeEdge, mxGmlShapeNode dataShapeNode)
	{
		this.dataId = dataId;
		this.dataKey = dataKey;
		this.dataValue = dataValue;
		this.dataShapeNode = dataShapeNode;
		this.dataShapeEdge = dataShapeEdge;
	}

	/**
	 * Construct a data from one xml data element.
	 * @param dataElement Xml Data Element.
	 */
	public mxGmlData(Element dataElement)
	{
		this.dataId = dataElement.getAttribute(mxGmlConstants.ID);
		this.dataKey = dataElement.getAttribute(mxGmlConstants.KEY);

		this.dataValue = "";

		Element shapeNodeElement = mxGmlUtils.childsTag(dataElement,
				mxGmlConstants.JGRAPH + mxGmlConstants.SHAPENODE);
		Element shapeEdgeElement = mxGmlUtils.childsTag(dataElement,
				mxGmlConstants.JGRAPH + mxGmlConstants.SHAPEEDGE);
		
		if (shapeNodeElement != null)
		{
			this.dataShapeNode = new mxGmlShapeNode(shapeNodeElement);
		}
		else if (shapeEdgeElement != null)
		{
			this.dataShapeEdge = new mxGmlShapeEdge(shapeEdgeElement);
		}
		else
		{
			NodeList childs = dataElement.getChildNodes();
			List<Node> childrens = mxGmlUtils.copyNodeList(childs);
			
			for (Node n : childrens)
			{
				if (n.getNodeName().equals("#text"))
				{

					this.dataValue += n.getNodeValue();
				}
			}
			this.dataValue = this.dataValue.trim();
		}
	}

	/**
	 * Construct an empty data.
	 */
	public mxGmlData()
	{
	}

	public String getDataId()
	{
		return dataId;
	}

	public void setDataId(String dataId)
	{
		this.dataId = dataId;
	}

	public String getDataKey()
	{
		return dataKey;
	}

	public void setDataKey(String dataKey)
	{
		this.dataKey = dataKey;
	}

	public String getDataValue()
	{
		return dataValue;
	}

	public void setDataValue(String dataValue)
	{
		this.dataValue = dataValue;
	}

	public mxGmlShapeNode getDataShapeNode()
	{
		return dataShapeNode;
	}

	public void setDataShapeNode(mxGmlShapeNode dataShapeNode)
	{
		this.dataShapeNode = dataShapeNode;
	}

	public mxGmlShapeEdge getDataShapeEdge()
	{
		return dataShapeEdge;
	}

	public void setDataShapeEdge(mxGmlShapeEdge dataShapeEdge)
	{
		this.dataShapeEdge = dataShapeEdge;
	}

	/**
	 * Generates an Node Data Element from this class.
	 * @param document Document where the key Element will be inserted.
	 * @return Returns the generated Elements.
	 */
	public Element generateNodeElement(Document document)
	{
		Element data = document.createElement(mxGmlConstants.DATA);
		data.setAttribute(mxGmlConstants.KEY, dataKey);

		Element shapeNodeElement = dataShapeNode.generateElement(document);
		data.appendChild(shapeNodeElement);

		return data;
	}

	/**
	 * Generates an Edge Data Element from this class.
	 * @param document Document where the key Element will be inserted.
	 * @return Returns the generated Elements.
	 */
	public Element generateEdgeElement(Document document)
	{
		Element data = document.createElement(mxGmlConstants.DATA);
		data.setAttribute(mxGmlConstants.KEY, dataKey);

		Element shapeEdgeElement = dataShapeEdge.generateElement(document);
		data.appendChild(shapeEdgeElement);

		return data;
	}
}
