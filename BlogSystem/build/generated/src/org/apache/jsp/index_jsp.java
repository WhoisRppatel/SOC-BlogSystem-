package org.apache.jsp;

import javax.servlet.*;
import javax.servlet.http.*;
import javax.servlet.jsp.*;

public final class index_jsp extends org.apache.jasper.runtime.HttpJspBase
    implements org.apache.jasper.runtime.JspSourceDependent {

  private static final JspFactory _jspxFactory = JspFactory.getDefaultFactory();

  private static java.util.List<String> _jspx_dependants;

  private org.glassfish.jsp.api.ResourceInjector _jspx_resourceInjector;

  public java.util.List<String> getDependants() {
    return _jspx_dependants;
  }

  public void _jspService(HttpServletRequest request, HttpServletResponse response)
        throws java.io.IOException, ServletException {

    PageContext pageContext = null;
    HttpSession session = null;
    ServletContext application = null;
    ServletConfig config = null;
    JspWriter out = null;
    Object page = this;
    JspWriter _jspx_out = null;
    PageContext _jspx_page_context = null;

    try {
      response.setContentType("text/html");
      pageContext = _jspxFactory.getPageContext(this, request, response,
      			null, true, 8192, true);
      _jspx_page_context = pageContext;
      application = pageContext.getServletContext();
      config = pageContext.getServletConfig();
      session = pageContext.getSession();
      out = pageContext.getOut();
      _jspx_out = out;
      _jspx_resourceInjector = (org.glassfish.jsp.api.ResourceInjector) application.getAttribute("com.sun.appserv.jsp.resource.injector");

      out.write("<!DOCTYPE html>\n");
      out.write("<html>\n");
      out.write("\n");
      out.write("<head>\n");
      out.write("    <link rel='stylesheet' href='https://cdnjs.cloudflare.com/ajax/libs/materialize/1.0.0/css/materialize.min.css'>\n");
      out.write("    <link href='https://fonts.googleapis.com/icon?family=Material+Icons' rel='stylesheet'>\n");
      out.write("    <script src='https://cdnjs.cloudflare.com/ajax/libs/materialize/1.0.0/js/materialize.min.js'></script>\n");
      out.write("    <meta charset=\"utf-8\" />\n");
      out.write("    <meta name=\"viewport\" content=\"width=device-width, initial-scale=1.0\">\n");
      out.write("    <style type=\"text/css\">\n");
      out.write("        .login-form {\n");
      out.write("            width: 340px;\n");
      out.write("            margin: 50px auto;\n");
      out.write("        }\n");
      out.write("            .login-form form {\n");
      out.write("                margin-bottom: 15px;\n");
      out.write("                background: #f7f7f7;\n");
      out.write("                box-shadow: 0px 2px 2px rgba(0, 0, 0, 0.3);\n");
      out.write("                padding: 30px;\n");
      out.write("            }\n");
      out.write("            .login-form h2 {\n");
      out.write("                margin: 0 0 15px;\n");
      out.write("            }\n");
      out.write("        .form-control, .btn {\n");
      out.write("            min-height: 38px;\n");
      out.write("            border-radius: 2px;\n");
      out.write("        }\n");
      out.write("        .btn {\n");
      out.write("            font-size: 15px;\n");
      out.write("            font-weight: bold;\n");
      out.write("        }\n");
      out.write("    </style>\n");
      out.write("</head>\n");
      out.write("<body style=\"background-image:url('images/home.jpg');\">\n");
      out.write("    \n");
      out.write("    <form action=\"dologin.jsp\" method=\"post\" class=\"center\">\n");
      out.write("        <div class='row container right'>\n");
      out.write("        \n");
      out.write("        <div class=\"container-fluid center\" style=\"width:60%;height:400px ; background-color:whitesmoke;\">\n");
      out.write("\n");
      out.write("            <div class=\"login-form\">\n");
      out.write("                <br />\n");
      out.write("                <h2 class=\"text-center display-4\">Log in</h2>\n");
      out.write("                <hr />\n");
      out.write("                <br />\n");
      out.write("                <div class=\"form-group\">\n");
      out.write("                    <input class=\"form-control input-sm chat-input\" name=\"unm\" type=\"text\" placeholder = \"Username\" style = \"width:400px;\" required>\n");
      out.write("             \n");
      out.write("                </div>\n");
      out.write("                 <br />\n");
      out.write("                <div class=\"form-group\">\n");
      out.write("                           <input class=\"form-control input-sm chat-input\" name=\"pass\" type=\"text\" placeholder = \"Password\" style = \"width:400px;\" required>\n");
      out.write("                   \n");
      out.write("                </div>\n");
      out.write("                 <br />\n");
      out.write("                <div class=\"form-group center \">\n");
      out.write("                        \n");
      out.write("                    <button type=\"submit\" class=\"  btn center\" style=\"width:200px\">Log in</button>\n");
      out.write("                </div>\n");
      out.write("                 <br /><br />\n");
      out.write("                <a href=\"register.jsp\">Create an Account</a>\n");
      out.write("            </div>\n");
      out.write("        \n");
      out.write("        </div>\n");
      out.write("        </div>\n");
      out.write("    </form>\n");
      out.write("</body>\n");
      out.write("</html>");
    } catch (Throwable t) {
      if (!(t instanceof SkipPageException)){
        out = _jspx_out;
        if (out != null && out.getBufferSize() != 0)
          out.clearBuffer();
        if (_jspx_page_context != null) _jspx_page_context.handlePageException(t);
        else throw new ServletException(t);
      }
    } finally {
      _jspxFactory.releasePageContext(_jspx_page_context);
    }
  }
}
