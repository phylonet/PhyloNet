/**
 * $Id: mxGmlShapeEdge.java,v 1.1 2010-09-08 14:52:50 david Exp $
 * Copyright (c) 2010 David Benson, Gaudenz Alder
 */
package com.mxgraph.io.gml;

import org.w3c.dom.Document;
import org.w3c.dom.Element;

/**
 * This class represents the properties of a JGraph edge.
 */
public class mxGmlShapeEdge
{
	private String text = "";

	private String style = "";

	private String edgeSource;

	private String edgeTarget;

	/**
	 * Construct a Shape Edge with text and style.
	 * @param text
	 * @param style
	 */
	public mxGmlShapeEdge(String text, String style)
	{
		this.text = text;
		this.style = style;
	}

	/**
	 * Constructs a ShapeEdge from a xml shapeEdgeElement.
	 * @param shapeEdgeElement
	 */
	public mxGmlShapeEdge(Element shapeEdgeElement)
	{
		Element labelElement = mxGmlUtils.childsTag(shapeEdgeElement,
				mxGmlConstants.JGRAPH + mxGmlConstants.LABEL);
		
		if (labelElement != null)
		{
			this.text = labelElement.getAttribute(mxGmlConstants.TEXT);
		}

		Element styleElement = mxGmlUtils.childsTag(shapeEdgeElement,
				mxGmlConstants.JGRAPH + mxGmlConstants.STYLE);
		
		if (styleElement != null)
		{
			this.style = styleElement.getAttribute(mxGmlConstants.PROPERTIES);

		}
	}

	/**
	 * Construct an empty Shape Edge Element.
	 */
	public mxGmlShapeEdge()
	{
	}

	/**
	 * Generates a ShapeEdge Element from this class.
	 * @param document Document where the key Element will be inserted.
	 * @return Returns the generated Elements.
	 */
	public Element generateElement(Document document)
	{
		Element dataEdge = document.createElementNS(mxGmlConstants.JGRAPH_URL,
				mxGmlConstants.JGRAPH + mxGmlConstants.SHAPEEDGE);

		if (!this.text.equals(""))
		{
			Element dataEdgeLabel = document.createElementNS(
					mxGmlConstants.JGRAPH_URL, mxGmlConstants.JGRAPH
							+ mxGmlConstants.LABEL);
			dataEdgeLabel.setAttribute(mxGmlConstants.TEXT, this.text);
			dataEdge.appendChild(dataEdgeLabel);
		}
		
		if (!this.style.equals(""))
		{
			Element dataEdgeStyle = document.createElementNS(
					mxGmlConstants.JGRAPH_URL, mxGmlConstants.JGRAPH
							+ mxGmlConstants.STYLE);

			dataEdgeStyle.setAttribute(mxGmlConstants.PROPERTIES, this.style);
			dataEdge.appendChild(dataEdgeStyle);
		}

		return dataEdge;
	}

	public String getText()
	{
		return text;
	}

	public void setText(String text)
	{
		this.text = text;
	}

	public String getStyle()
	{
		return style;
	}

	public void setStyle(String style)
	{
		this.style = style;
	}

	public String getEdgeSource()
	{
		return edgeSource;
	}

	public void setEdgeSource(String edgeSource)
	{
		this.edgeSource = edgeSource;
	}

	public String getEdgeTarget()
	{
		return edgeTarget;
	}

	public void setEdgeTarget(String edgeTarget)
	{
		this.edgeTarget = edgeTarget;
	}
}
