
package org.tempuri;

import javax.xml.bind.JAXBElement;
import javax.xml.bind.annotation.XmlAccessType;
import javax.xml.bind.annotation.XmlAccessorType;
import javax.xml.bind.annotation.XmlElementRef;
import javax.xml.bind.annotation.XmlRootElement;
import javax.xml.bind.annotation.XmlType;


/**
 * <p>Classe Java de anonymous complex type.
 * 
 * <p>O seguinte fragmento do esquema especifica o conteúdo esperado contido dentro desta classe.
 * 
 * <pre>
 * &lt;complexType&gt;
 *   &lt;complexContent&gt;
 *     &lt;restriction base="{http://www.w3.org/2001/XMLSchema}anyType"&gt;
 *       &lt;sequence&gt;
 *         &lt;element name="n1" type="{http://www.w3.org/2001/XMLSchema}string" minOccurs="0"/&gt;
 *         &lt;element name="n2" type="{http://www.w3.org/2001/XMLSchema}string" minOccurs="0"/&gt;
 *         &lt;element name="op" type="{http://www.w3.org/2001/XMLSchema}string" minOccurs="0"/&gt;
 *       &lt;/sequence&gt;
 *     &lt;/restriction&gt;
 *   &lt;/complexContent&gt;
 * &lt;/complexType&gt;
 * </pre>
 * 
 * 
 */
@XmlAccessorType(XmlAccessType.FIELD)
@XmlType(name = "", propOrder = {
    "n1",
    "n2",
    "op"
})
@XmlRootElement(name = "Calcular")
public class Calcular {

    @XmlElementRef(name = "n1", namespace = "http://tempuri.org/", type = JAXBElement.class, required = false)
    protected JAXBElement<String> n1;
    @XmlElementRef(name = "n2", namespace = "http://tempuri.org/", type = JAXBElement.class, required = false)
    protected JAXBElement<String> n2;
    @XmlElementRef(name = "op", namespace = "http://tempuri.org/", type = JAXBElement.class, required = false)
    protected JAXBElement<String> op;

    /**
     * Obtém o valor da propriedade n1.
     * 
     * @return
     *     possible object is
     *     {@link JAXBElement }{@code <}{@link String }{@code >}
     *     
     */
    public JAXBElement<String> getN1() {
        return n1;
    }

    /**
     * Define o valor da propriedade n1.
     * 
     * @param value
     *     allowed object is
     *     {@link JAXBElement }{@code <}{@link String }{@code >}
     *     
     */
    public void setN1(JAXBElement<String> value) {
        this.n1 = value;
    }

    /**
     * Obtém o valor da propriedade n2.
     * 
     * @return
     *     possible object is
     *     {@link JAXBElement }{@code <}{@link String }{@code >}
     *     
     */
    public JAXBElement<String> getN2() {
        return n2;
    }

    /**
     * Define o valor da propriedade n2.
     * 
     * @param value
     *     allowed object is
     *     {@link JAXBElement }{@code <}{@link String }{@code >}
     *     
     */
    public void setN2(JAXBElement<String> value) {
        this.n2 = value;
    }

    /**
     * Obtém o valor da propriedade op.
     * 
     * @return
     *     possible object is
     *     {@link JAXBElement }{@code <}{@link String }{@code >}
     *     
     */
    public JAXBElement<String> getOp() {
        return op;
    }

    /**
     * Define o valor da propriedade op.
     * 
     * @param value
     *     allowed object is
     *     {@link JAXBElement }{@code <}{@link String }{@code >}
     *     
     */
    public void setOp(JAXBElement<String> value) {
        this.op = value;
    }

}
