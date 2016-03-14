/**
 * $Id: mxGmlShapeNode.java,v 1.1 2010-09-08 14:52:50 david Exp $
 * Copyright (c) 2010 David Benson, Gaudenz Alder
 */
package com.mxgraph.io.gml;

import org.w3c.dom.Document;
import org.w3c.dom.Element;

public class mxGmlShapeNode
{
	private String dataHeight = "";

	private String dataWidth = "";

	private String dataX = "";

	private String dataY = "";

	private String dataLabel = "";

	private String dataStyle = "";

	/**
	 * Construct a shape Node with the given parameters
	 * @param dataHeight Node's Height
	 * @param dataWidth Node's Width
	 * @param dataX Node's X coordinate.
	 * @param dataY Node's Y coordinate.
	 * @param dataStyle Node's style.
	 */
	public mxGmlShapeNode(String dataHeight, String dataWidth, String dataX,
			String dataY, String dataStyle)
	{
		this.dataHeight = dataHeight;
		this.dataWidth = dataWidth;
		this.dataX = dataX;
		this.dataY = dataY;
		this.dataStyle = dataStyle;
	}

	/**
	 * Construct an empty shape Node
	 */
	public mxGmlShapeNode()
	{
	}

	/**
	 * Construct a Shape Node from a xml Shape Node Element.
	 * @param shapeNodeElement Xml Shape Node Element.
	 */
	public mxGmlShapeNode(Element shapeNodeElement)
	{
		//Defines Geometry
		Element geometryElement = mxGmlUtils.childsTag(shapeNodeElement,
				mxGmlConstants.JGRAPH + mxGmlConstants.GEOMETRY);
		this.dataHeight = geometryElement.getAttribute(mxGmlConstants.HEIGHT);
		this.dataWidth = geometryElement.getAttribute(mxGmlConstants.WIDTH);
		this.dataX = geometryElement.getAttribute(mxGmlConstants.X);
		this.dataY = geometryElement.getAttribute(mxGmlConstants.Y);

		Element styleElement = mxGmlUtils.childsTag(shapeNodeElement,
				mxGmlConstants.JGRAPH + mxGmlConstants.STYLE);
		
		if (styleElement != null)
		{
			this.dataStyle = styleElement
					.getAttribute(mxGmlConstants.PROPERTIES);
		}
		//Defines Label
		Element labelElement = mxGmlUtils.childsTag(shapeNodeElement,
				mxGmlConstants.JGRAPH + mxGmlConstants.LABEL);
		
		if (labelElement != null)
		{
			this.dataLabel = labelElement.getAttribute(mxGmlConstants.TEXT);
		}
	}

	/**
	 * Generates a Shape Node Element from this class.
	 * @param document Document where the key Element will be inserted.
	 * @return Returns the generated Elements.
	 */
	public Element generateElement(Document document)
	{
		Element dataShape = document.createElementNS(mxGmlConstants.JGRAPH_URL,
				mxGmlConstants.JGRAPH + mxGmlConstants.SHAPENODE);

		Element dataShapeGeometry = document.createElementNS(
				mxGmlConstants.JGRAPH_URL, mxGmlConstants.JGRAPH
						+ mxGmlConstants.GEOMETRY);
		dataShapeGeometry.setAttribute(mxGmlConstants.HEIGHT, dataHeight);
		dataShapeGeometry.setAttribute(mxGmlConstants.WIDTH, dataWidth);
		dataShapeGeometry.setAttribute(mxGmlConstants.X, dataX);
		dataShapeGeometry.setAttribute(mxGmlConstants.Y, dataY);

		dataShape.appendChild(dataShapeGeometry);

		if (!this.dataStyle.equals(""))
		{
			Element dataShapeStyle = document.createElementNS(
					mxGmlConstants.JGRAPH_URL, mxGmlConstants.JGRAPH
							+ mxGmlConstants.STYLE);
			dataShapeStyle.setAttribute(mxGmlConstants.PROPERTIES, dataStyle);
			dataShape.appendChild(dataShapeStyle);
		}

		//Sets Label
		if (!this.dataLabel.equals(""))
		{

			Element dataShapeLabel = document.createElementNS(
					mxGmlConstants.JGRAPH_URL, mxGmlConstants.JGRAPH
							+ mxGmlConstants.LABEL);
			dataShapeLabel.setAttribute(mxGmlConstants.TEXT, dataLabel);

			dataShape.appendChild(dataShapeLabel);
		}
		
		return dataShape;
	}

	public String getDataHeight()
	{
		return dataHeight;
	}

	public void setDataHeight(String dataHeight)
	{
		this.dataHeight = dataHeight;
	}

	public String getDataWidth()
	{
		return dataWidth;
	}

	public void setDataWidth(String dataWidth)
	{
		this.dataWidth = dataWidth;
	}

	public String getDataX()
	{
		return dataX;
	}

	public void setDataX(String dataX)
	{
		this.dataX = dataX;
	}

	public String getDataY()
	{
		return dataY;
	}

	public void setDataY(String dataY)
	{
		this.dataY = dataY;
	}

	public String getDataLabel()
	{
		return dataLabel;
	}

	public void setDataLabel(String dataLabel)
	{
		this.dataLabel = dataLabel;
	}

	public String getDataStyle()
	{
		return dataStyle;
	}

	public void setDataStyle(String dataStyle)
	{
		this.dataStyle = dataStyle;
	}
}
