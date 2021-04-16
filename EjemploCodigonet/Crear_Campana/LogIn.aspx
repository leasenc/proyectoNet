<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LogIn.aspx.cs" Inherits="Crear_Campana.LogIn" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>CRM</title>
    <link rel="stylesheet" href="images/PixelGreen.css" type="text/css" />
</head>
<body>
    <div>
		<div id="header" ><div id="header-content">	
		
			<h1 id="logo">
			<a href="login.html" title="">last<span class="gray">one</span></a></h1>
			<h2 id="slogan">5 th Semester CRM Project</h2>	

		</div></div>
		
		<div id="main">
			<div class="post">
		
				<a name="LogIn"></a>
				<h1>LogIn</h1>
                
                <form id="form1" runat="server" style="background-color:Transparent;border-width:0">				
				<table class="style1">
					<tr>
						<td colspan="3" style="text-align: left">
						    <asp:Label ID="lblUser" runat="server" Text="Usuario"></asp:Label>						    
						</td>
						<td colspan="3" style="text-align: left">
						    <asp:TextBox ID="txtUser" runat="server"></asp:TextBox>
						    <asp:RequiredFieldValidator ID="rfvUser" runat="server" ControlToValidate="txtUser" ErrorMessage="Por favor ingrese el usuario"></asp:RequiredFieldValidator>
						</td>
					</tr>
					<tr>
						<td colspan="3" style="text-align: left">
							<asp:Label ID="lblPass" runat="server" Text="Password"></asp:Label>
						</td>
						<td colspan="3" style="text-align: left">
							<asp:TextBox ID="txtPass" runat="server" TextMode="Password"></asp:TextBox>
							<asp:RequiredFieldValidator ID="rfvPass" runat="server" ControlToValidate="txtUser" ErrorMessage="Por favor ingrese el password"></asp:RequiredFieldValidator>
						</td>
					</tr>
					
					<br />
					<br />
					
					<tr>
						<td />
						<td />
						<td />
						<td>
						    <asp:Button ID="btnSubmit" CssClass="button" runat="server" onclick="btnSubmit_Click" Text="Iniciar" />								    										    
						</td>
						
						<td>
                            <input name="Clear" class="button" type="reset" value="Limpiar" />    
						    <%--<input name="Submit"  type="submit" value="Submit" />--%>
						</td>
					</tr>
					
				</table>
                </form>
			</div>
		</div>
    
    </div>
                    
</body>
</html>
