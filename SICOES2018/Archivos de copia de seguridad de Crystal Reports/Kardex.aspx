﻿<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPages/mstrpgAdmin.Master" AutoEventWireup="true" CodeBehind="Kardex.aspx.cs" Inherits="SICOES2018.Reports.Kardex1" %>

<%@ Register Assembly="CrystalDecisions.Web, Version=13.0.3500.0, Culture=neutral, PublicKeyToken=692fbea5521e1304" Namespace="CrystalDecisions.Web" TagPrefix="CR" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="w3-row w3-padding">
        <a href="../GUI/GestionKardex.aspx"><i class="fa fa-arrow-left w3-large"></i>Regresar</a>
    </div>
    <div class="w3-row w3-padding w3-center">
        <CR:CrystalReportViewer ID="Kardex" runat="server" AutoDataBind="true" ToolPanelView="None" />
    </div>

</asp:Content>
