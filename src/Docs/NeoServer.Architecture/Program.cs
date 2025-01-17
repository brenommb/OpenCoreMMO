﻿// See https://aka.ms/new-console-template for more information

using C4Sharp.Elements.Plantuml.IO;
using NeoServer.Architecture.Diagrams;

var diagrams = new[]
{
    new ContainerDiagram().Build()
};

const string path = "../../../c4";

new PlantumlContext()
    .UseDiagramImageBuilder()
    .UseDiagramSvgImageBuilder()
    .UseStandardLibraryBaseUrl()
    //.UseHtmlPageBuilder()
    .Export(path, diagrams);