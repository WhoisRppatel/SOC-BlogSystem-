
package org.tempuri;

import javax.jws.WebMethod;
import javax.jws.WebParam;
import javax.jws.WebResult;
import javax.jws.WebService;
import javax.xml.bind.annotation.XmlSeeAlso;
import javax.xml.ws.RequestWrapper;
import javax.xml.ws.ResponseWrapper;
import org.datacontract.schemas._2004._07.wcfblogservicelibrary.ArrayOfMyBlog;
import org.datacontract.schemas._2004._07.wcfblogservicelibrary.MyBlog;


/**
 * This class was generated by the JAX-WS RI.
 * JAX-WS RI 2.2.6-1b01 
 * Generated source version: 2.1
 * 
 */
@WebService(name = "IBlog", targetNamespace = "http://tempuri.org/")
@XmlSeeAlso({
    com.microsoft.schemas._2003._10.serialization.ObjectFactory.class,
    org.datacontract.schemas._2004._07.wcfblogservicelibrary.ObjectFactory.class,
    org.tempuri.ObjectFactory.class
})
public interface IBlog {


    /**
     * 
     * @param value
     * @return
     *     returns java.lang.String
     */
    @WebMethod(operationName = "GetData", action = "http://tempuri.org/IBlog/GetData")
    @WebResult(name = "GetDataResult", targetNamespace = "http://tempuri.org/")
    @RequestWrapper(localName = "GetData", targetNamespace = "http://tempuri.org/", className = "org.tempuri.GetData")
    @ResponseWrapper(localName = "GetDataResponse", targetNamespace = "http://tempuri.org/", className = "org.tempuri.GetDataResponse")
    public String getData(
        @WebParam(name = "value", targetNamespace = "http://tempuri.org/")
        Integer value);

    /**
     * 
     * @param s
     * @return
     *     returns java.lang.String
     */
    @WebMethod(operationName = "AddBlog", action = "http://tempuri.org/IBlog/AddBlog")
    @WebResult(name = "AddBlogResult", targetNamespace = "http://tempuri.org/")
    @RequestWrapper(localName = "AddBlog", targetNamespace = "http://tempuri.org/", className = "org.tempuri.AddBlog")
    @ResponseWrapper(localName = "AddBlogResponse", targetNamespace = "http://tempuri.org/", className = "org.tempuri.AddBlogResponse")
    public String addBlog(
        @WebParam(name = "s", targetNamespace = "http://tempuri.org/")
        MyBlog s);

    /**
     * 
     * @return
     *     returns org.datacontract.schemas._2004._07.wcfblogservicelibrary.ArrayOfMyBlog
     */
    @WebMethod(operationName = "GetAllBlog", action = "http://tempuri.org/IBlog/GetAllBlog")
    @WebResult(name = "GetAllBlogResult", targetNamespace = "http://tempuri.org/")
    @RequestWrapper(localName = "GetAllBlog", targetNamespace = "http://tempuri.org/", className = "org.tempuri.GetAllBlog")
    @ResponseWrapper(localName = "GetAllBlogResponse", targetNamespace = "http://tempuri.org/", className = "org.tempuri.GetAllBlogResponse")
    public ArrayOfMyBlog getAllBlog();

}
