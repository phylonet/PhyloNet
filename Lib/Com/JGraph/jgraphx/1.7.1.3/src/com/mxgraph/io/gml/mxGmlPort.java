/**
 * $Id: mxGmlPort.java,v 1.1 2010-09-08 14:52:50 david Exp $
 * Copyright (c) 2010 David Benson, Gaudenz Alder
 */
package com.mxgraph.io.gml;

import java.util.HashMap;
import java.util.List;
import org.w3c.dom.Document;
import org.w3c.dom.Element;

/**
 * Represents a Port element in the GML Structure.
 */
public class mxGmlPort
{
	private String name;

	private HashMap<String, mxGmlData> portDataMap = new HashMap<String, mxGmlData>();

	/**
	 * Construct a Port with name.
	 * @param name Port Name
	 */
	public mxGmlPort(String name)
	{
		this.name = name;
	}

	/**
	 * Construct a Port from a xml port Element.
	 * @param portElement Xml port Element.
	 */
	public mxGmlPort(Element portElement)
	{
		this.name = portElement.getAttribute(mxGmlConstants.PORT_NAME);

		//Add data elements
		List<Element> dataList = mxGmlUtils.childsTags(portElement,
				mxGmlConstants.DATA);

		for (Element dataElem : dataList)
		{
			mxGmlData data = new mxGmlData(dataElem);
			String key = data.getDataKey();
			portDataMap.put(key, data);
		}
	}

	public String getName()
	{
		return name;
	}

	public void setName(String name)
	{
		this.name = name;
	}

	public HashMap<String, mxGmlData> getPortDataMap()
	{
		return portDataMap;
	}

	public void setPortDataMap(HashMap<String, mxGmlData> nodeDataMap)
	{
		this.portDataMap = nodeDataMap;
	}

	/**
	 * Generates a Key Element from this class.
	 * @param document Document where the key Element will be inserted.
	 * @return Returns the generated Elements.
	 */
	public Element generateElement(Document document)
	{
		Element node = document.createElement(mxGmlConstants.PORT);

		node.setAttribute(mxGmlConstants.PORT_NAME, name);

		for (mxGmlData data : portDataMap.values())
		{
			Element dataElement = data.generateNodeElement(document);
			node.appendChild(dataElement);
		}

		return node;
	}
}
