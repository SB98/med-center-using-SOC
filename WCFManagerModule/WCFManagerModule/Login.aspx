<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="WCFManagerModule.Login" EnableEventValidation="false" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link rel="stylesheet" href="css/bootstrap.min.css"/>
	<link rel="stylesheet" type="text/css" href="css/style.css"/>
</head>
<body>
    <form runat="server">
   <header>
		<div class="header_top">
			<div class="container">
				<div class="row">
					<div class="col-4">
						<div class="logo">
							<a href="index.html"><img src="img/logo1.png" class="img-responsive" /></a>
						</div>
					</div>
					<div class="col-8">
						<a href="Signup.aspx" class="btn btn-info btn1"> Sign Up</a>
					</div>
				</div>
			</div>
		</div>
	</header>
	<main>
		<section id="loginform">
			<div class="container">
				<div class="row">
					<div class="col-3">
						
					</div>
					<div class="col-6">
						
						<form>
							<div class="form">
								<h2 class="text-center">Sign In</h2>
								
								<div class="form-group">
									<label  class="control-label col">Email:</label>
									<div class="col-12">
										<asp:TextBox ID="txtemail" runat="server" class="form-control" type="email" name="mail"/>
									</div>
								</div>
								<div class="form-group">
									<label  class="control-label col">Password:</label>
									<div class="col-12">
										<asp:TextBox ID="txtpass" runat="server" class="form-control" type="password" name="pass"/>
									</div>
								</div>
								
								<div class="form-group text-right">
									<div class="col">
										<asp:Button ID="btnsignin" runat="server" class="btn frm-btn" Text="Sign In" OnClick="btnsignin_Click"></asp:Button>
									</div>
								</div>
							</div>
						</form>
					</div>
					<div class="col-3">
					</div>
				</div>
			</div>
		</section>
	</main>
	<footer>
		<div class="container">
			<div class="row">
				<div class="col text-center">
					<p>&copy; Copyrights are Reserved 2018-19</p>
				</div>
			</div>
		</div>
	</footer>
        </form>
</body>
</html>
