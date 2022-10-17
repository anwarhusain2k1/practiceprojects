<%@ Page Title="school" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="school_webform.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <body >
        <p>
            &nbsp;
        </p>
        <p style="font-family: 'Times New Roman', Times, serif; font-size: large">
            Student Id&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; :
            <asp:TextBox ID="TextBox5" runat="server" Height="28px" TextMode="Number" Width="206px"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="TextBox5" ErrorMessage="Id can't be empty" ForeColor="#FF3300"></asp:RequiredFieldValidator>
        </p>
        <p style="font-family: 'Times New Roman', Times, serif; font-size: large">
            Student Name&nbsp;&nbsp; :
            <asp:TextBox ID="TextBox4" runat="server" Width="206px"></asp:TextBox>
        </p>
        <p style="font-family: 'Times New Roman', Times, serif; font-size: large">
            Student Class&nbsp;&nbsp;&nbsp; :
            <asp:TextBox ID="TextBox6" runat="server" Width="201px"></asp:TextBox>
        </p>
        <p style="font-family: 'Times New Roman', Times, serif; font-size: large">
            Student Email&nbsp;&nbsp; :
            <asp:TextBox ID="TextBox2" runat="server" TextMode="Email" Width="203px"></asp:TextBox>
        </p>
        <p style="font-family: 'Times New Roman', Times, serif; font-size: large">
            Contact number:
            <asp:TextBox ID="TextBox1" runat="server" TextMode="Phone" Width="204px"></asp:TextBox>
        </p>
        <p style="font-family: 'Times New Roman', Times, serif; font-size: large">
            &nbsp;
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Submit" />
        </p>
    </body>
</asp:Content>
