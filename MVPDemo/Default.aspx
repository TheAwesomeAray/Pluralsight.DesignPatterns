<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
        <h1><%: ViewModel.Title %></h1>
    </div>
    <asp:HiddenField runat="server" Value="false" ID="sortedHiddenField" />



    <asp:Repeater ID="manufacturersRepeater" runat="server">
        <HeaderTemplate>
            <table>
                <tr>
                    <td>
                        <asp:LinkButton ID="nameSort" runat="server" Text="Name" OnClick="Sort_Click" />
                    </td>
                </tr>
        </HeaderTemplate>
        <ItemTemplate>
            <tr>
                <td>
                    <%# Eval("Name") %>
                </td>
            </tr>
        </ItemTemplate>
        <FooterTemplate>
            </table>
        </FooterTemplate>
    </asp:Repeater>
</asp:Content>
