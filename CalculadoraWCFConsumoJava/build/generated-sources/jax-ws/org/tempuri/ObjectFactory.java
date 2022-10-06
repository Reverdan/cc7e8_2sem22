
package org.tempuri;

import javax.xml.bind.JAXBElement;
import javax.xml.bind.annotation.XmlElementDecl;
import javax.xml.bind.annotation.XmlRegistry;
import javax.xml.namespace.QName;


/**
 * This object contains factory methods for each 
 * Java content interface and Java element interface 
 * generated in the org.tempuri package. 
 * <p>An ObjectFactory allows you to programatically 
 * construct new instances of the Java representation 
 * for XML content. The Java representation of XML 
 * content can consist of schema derived interfaces 
 * and classes representing the binding of schema 
 * type definitions, element declarations and model 
 * groups.  Factory methods for each of these are 
 * provided in this class.
 * 
 */
@XmlRegistry
public class ObjectFactory {

    private final static QName _CalcularN1_QNAME = new QName("http://tempuri.org/", "n1");
    private final static QName _CalcularN2_QNAME = new QName("http://tempuri.org/", "n2");
    private final static QName _CalcularOp_QNAME = new QName("http://tempuri.org/", "op");
    private final static QName _CalcularResponseCalcularResult_QNAME = new QName("http://tempuri.org/", "CalcularResult");

    /**
     * Create a new ObjectFactory that can be used to create new instances of schema derived classes for package: org.tempuri
     * 
     */
    public ObjectFactory() {
    }

    /**
     * Create an instance of {@link Calcular }
     * 
     */
    public Calcular createCalcular() {
        return new Calcular();
    }

    /**
     * Create an instance of {@link CalcularResponse }
     * 
     */
    public CalcularResponse createCalcularResponse() {
        return new CalcularResponse();
    }

    /**
     * Create an instance of {@link JAXBElement }{@code <}{@link String }{@code >}
     * 
     * @param value
     *     Java instance representing xml element's value.
     * @return
     *     the new instance of {@link JAXBElement }{@code <}{@link String }{@code >}
     */
    @XmlElementDecl(namespace = "http://tempuri.org/", name = "n1", scope = Calcular.class)
    public JAXBElement<String> createCalcularN1(String value) {
        return new JAXBElement<String>(_CalcularN1_QNAME, String.class, Calcular.class, value);
    }

    /**
     * Create an instance of {@link JAXBElement }{@code <}{@link String }{@code >}
     * 
     * @param value
     *     Java instance representing xml element's value.
     * @return
     *     the new instance of {@link JAXBElement }{@code <}{@link String }{@code >}
     */
    @XmlElementDecl(namespace = "http://tempuri.org/", name = "n2", scope = Calcular.class)
    public JAXBElement<String> createCalcularN2(String value) {
        return new JAXBElement<String>(_CalcularN2_QNAME, String.class, Calcular.class, value);
    }

    /**
     * Create an instance of {@link JAXBElement }{@code <}{@link String }{@code >}
     * 
     * @param value
     *     Java instance representing xml element's value.
     * @return
     *     the new instance of {@link JAXBElement }{@code <}{@link String }{@code >}
     */
    @XmlElementDecl(namespace = "http://tempuri.org/", name = "op", scope = Calcular.class)
    public JAXBElement<String> createCalcularOp(String value) {
        return new JAXBElement<String>(_CalcularOp_QNAME, String.class, Calcular.class, value);
    }

    /**
     * Create an instance of {@link JAXBElement }{@code <}{@link String }{@code >}
     * 
     * @param value
     *     Java instance representing xml element's value.
     * @return
     *     the new instance of {@link JAXBElement }{@code <}{@link String }{@code >}
     */
    @XmlElementDecl(namespace = "http://tempuri.org/", name = "CalcularResult", scope = CalcularResponse.class)
    public JAXBElement<String> createCalcularResponseCalcularResult(String value) {
        return new JAXBElement<String>(_CalcularResponseCalcularResult_QNAME, String.class, CalcularResponse.class, value);
    }

}
