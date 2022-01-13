<%@ Page Language="vb" AutoEventWireup="false" Codebehind="DB2XML.vb" src="DB2XML.vb" Inherits="clsdb2x" debug="true" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN">
<HTML>
	<HEAD>
		<title>Creating XML File</title>
		<meta content="Visual Basic 7.0" name="CODE_LANGUAGE">
		<meta content="http://schemas.microsoft.com/intellisense/ie5" name="vs_targetSchema">
		<style type="text/css">
			.tanor1 { FONT-WEIGHT: normal; FONT-SIZE: 12px; COLOR: #000000; FONT-FAMILY: verdana, arial, helvetica, sans-serif }
		</style>
	</HEAD>
	<BODY topmargin="25">
		<form id="frmdb2xml" method="post" runat="server">
			<table cellSpacing="0" cellPadding="0" width="50%" align="center" borderColorLight="#ffcc66" border="1">
				<tr height="35">
					<td align="middle" colSpan="2"><FONT face="verdana" color="#6699ff" size="4"><b>Convert 
								DataBase to XMl File</b></FONT>
					</td>
				</tr>
				<tr>
					<td>
						<TABLE id="Table1" style="FONT-SIZE: 13px; FONT-FAMILY: verdana" cellSpacing="0" cellPadding="0" width="100%" align="center" border="0">
							<TBODY>
								<tr height="20">
									<td><font face="verdana" color="darkgray" size="1"></font>
									</td>
								</tr>
								<tr>
									<td align="middle" width="70%">
										<table style="BORDER-COLLAPSE: collapse" borderColor="gainsboro" bgcolor="#fafafa" cellSpacing="0" cellPadding="0" width="70%" border="1">
											<tr height="25">
												<TD class="tanor1" noWrap align="right">Select Table&nbsp;</TD>
												<td valign="top">
													<asp:listbox id="ListBox1" runat="server" Height="120px" Width="186px" SelectionMode="Multiple">
														<asp:ListItem Value="0">-- All --</asp:ListItem>
														<asp:ListItem Value="1">Category</asp:ListItem>
														<asp:ListItem Value="2">SubCategory</asp:ListItem>
														<asp:ListItem Value="3">Product</asp:ListItem>
														<asp:ListItem Value="4">Customer</asp:ListItem>
														<asp:ListItem Value="7">Project</asp:ListItem>
														<asp:ListItem Value="8">City</asp:ListItem>
														<asp:ListItem Value="9">State</asp:ListItem>
														<asp:ListItem Value="10">Country</asp:ListItem>
													</asp:listbox>
												</td>
											</tr>
										</table>
									</td>
								</tr>
								<TR height="30">
									<td align="middle" colSpan="2">
										<asp:button id="Button1" style="CURSOR: hand" accessKey="E" tooltip="Click to Export Files" Height="24px" Runat="server" Text="Convert" Font-Bold="True"></asp:button>
									</td>
								<tr>
								</tr>
							</TBODY>
						</TABLE>
					</td>
				</tr>
			</table>
			<br>
			<asp:Label id="message" runat="server" />
		</form>
	</BODY>
</HTML>
