Language="VBSCRIPT"

Sub CATMain()

/***************/
/* init part1 */
/***************/

Set partDocument1 = CATIA.ActiveDocument

Set part1 = partDocument1.Part

Set bodies1 = part1.Bodies

Set body1 = bodies1.Item("Corps principal")

/****************************/
/* init sketches1 for body1 */
/****************************/

Set sketches1 = body1.Sketches

Set originElements1 = part1.OriginElements

Set reference1 = originElements1.PlaneYZ

/****************/
/* init sketch1 */
/****************/

Set sketch1 = sketches1.Add(reference1)

Dim arrayOfVariantOfDouble1(8)
arrayOfVariantOfDouble1(0) = 0.000000
arrayOfVariantOfDouble1(1) = 0.000000
arrayOfVariantOfDouble1(2) = 0.000000
arrayOfVariantOfDouble1(3) = 0.000000
arrayOfVariantOfDouble1(4) = 1.000000
arrayOfVariantOfDouble1(5) = 0.000000
arrayOfVariantOfDouble1(6) = 0.000000
arrayOfVariantOfDouble1(7) = 0.000000
arrayOfVariantOfDouble1(8) = 1.000000
sketch1.SetAbsoluteAxisData arrayOfVariantOfDouble1

part1.InWorkObject = sketch1

Set factory2D1 = sketch1.OpenEdition()

Set geometricElements1 = sketch1.GeometricElements

Set axis2D1 = geometricElements1.Item("Repère")

Set line2D1 = axis2D1.GetItem("Axe horizontal")

line2D1.ReportName = 1

Set line2D2 = axis2D1.GetItem("Axe vertical")

line2D2.ReportName = 2

/***************/
/* set sketch1 */
/***************/

Set point2D1 = factory2D1.CreatePoint(60.000000, 0.000000)

point2D1.ReportName = 3

Set line2D3 = factory2D1.CreateLine(0.000000, 0.000000, 60.000000, 0.000000)

line2D3.ReportName = 4

Set point2D2 = axis2D1.GetItem("Origine")

line2D3.StartPoint = point2D2

line2D3.EndPoint = point2D1

Set point2D3 = factory2D1.CreatePoint(60.000000, 60.000000)

point2D3.ReportName = 5

Set line2D4 = factory2D1.CreateLine(60.000000, -0.000000, 60.000000, 60.000000)

line2D4.ReportName = 6

line2D4.StartPoint = point2D1

line2D4.EndPoint = point2D3

Set point2D4 = factory2D1.CreatePoint(-0.000000, 60.000000)

point2D4.ReportName = 7

Set line2D5 = factory2D1.CreateLine(60.000000, 60.000000, -0.000000, 60.000000)

line2D5.ReportName = 8

line2D5.StartPoint = point2D3

line2D5.EndPoint = point2D4

Set line2D6 = factory2D1.CreateLine(0.000000, 60.000000, 0.000000, 0.000000)

line2D6.ReportName = 9

line2D6.StartPoint = point2D4

line2D6.EndPoint = point2D2

/*********************************/
/* init constraints1 for sketch1 */
/*********************************/

Set constraints1 = sketch1.Constraints

/********************************/
/* set constraints1 for sketch1 */
/********************************/

Set reference2 = part1.CreateReferenceFromObject(line2D3)

Set reference3 = part1.CreateReferenceFromObject(line2D1)

Set constraint1 = constraints1.AddBiEltCst(catCstTypeHorizontality, reference2, reference3)

constraint1.Mode = catCstModeDrivingDimension

Set reference4 = part1.CreateReferenceFromObject(line2D5)

Set reference5 = part1.CreateReferenceFromObject(line2D1)

Set constraint2 = constraints1.AddBiEltCst(catCstTypeHorizontality, reference4, reference5)

constraint2.Mode = catCstModeDrivingDimension

Set reference6 = part1.CreateReferenceFromObject(line2D4)

Set reference7 = part1.CreateReferenceFromObject(line2D2)

Set constraint3 = constraints1.AddBiEltCst(catCstTypeVerticality, reference6, reference7)

constraint3.Mode = catCstModeDrivingDimension

Set reference8 = part1.CreateReferenceFromObject(line2D6)

Set reference9 = part1.CreateReferenceFromObject(line2D2)

Set constraint4 = constraints1.AddBiEltCst(catCstTypeVerticality, reference8, reference9)

constraint4.Mode = catCstModeDrivingDimension

Set reference10 = part1.CreateReferenceFromObject(line2D5)

Set constraint5 = constraints1.AddMonoEltCst(catCstTypeLength, reference10)

constraint5.Mode = catCstModeDrivingDimension

Set length1 = constraint5.Dimension

length1.Value = 60.000000

Set reference11 = part1.CreateReferenceFromObject(line2D4)

Set constraint6 = constraints1.AddMonoEltCst(catCstTypeLength, reference11)

constraint6.Mode = catCstModeDrivingDimension

Set length2 = constraint6.Dimension

length2.Value = 60.000000

/***********************/
/* end edition sketch1 */
/***********************/

sketch1.CloseEdition 

part1.InWorkObject = sketch1

part1.Update 

/************************/
/* extrusion of sketch1 */
/************************/

Set shapeFactory1 = part1.ShapeFactory

Set pad1 = shapeFactory1.AddNewPad(sketch1, 20.000000)

Set limit1 = pad1.FirstLimit

Set length3 = limit1.Dimension

length3.Value = 60.000000

part1.Update 

Set reference12 = part1.CreateReferenceFromName("Selection_RSur:(Face:(Brp:(Pad.1;0:(Brp:(Sketch.1;8)));None:();Cf11:());Pad.1_ResultOUT;Z0;G3563)")

/****************/
/* init sketch2 */
/****************/

Set sketch2 = sketches1.Add(reference12)

Dim arrayOfVariantOfDouble2(8)
arrayOfVariantOfDouble2(0) = 0.000000
arrayOfVariantOfDouble2(1) = 0.000000
arrayOfVariantOfDouble2(2) = 60.000000
arrayOfVariantOfDouble2(3) = 1.000000
arrayOfVariantOfDouble2(4) = 0.000000
arrayOfVariantOfDouble2(5) = 0.000000
arrayOfVariantOfDouble2(6) = 0.000000
arrayOfVariantOfDouble2(7) = 1.000000
arrayOfVariantOfDouble2(8) = -0.000000
sketch2.SetAbsoluteAxisData arrayOfVariantOfDouble2

part1.InWorkObject = sketch2

Set factory2D2 = sketch2.OpenEdition()

Set geometricElements2 = sketch2.GeometricElements

Set axis2D2 = geometricElements2.Item("Repère")

Set line2D7 = axis2D2.GetItem("Axe horizontal")

line2D7.ReportName = 1

Set line2D8 = axis2D2.GetItem("Axe vertical")

line2D8.ReportName = 2

Set point2D5 = factory2D2.CreatePoint(30.000000, 30.000000)

point2D5.ReportName = 3

point2D5.Construction = False

Set reference13 = part1.CreateReferenceFromBRepName("FEdge:(Edge:(Face:(Brp:(Pad.1;1);None:();Cf11:());Face:(Brp:(Pad.1;0:(Brp:(Sketch.1;8)));None:();Cf11:());None:(Limits1:();Limits2:());Cf11:());WithPermanentBody;WithoutBuildError;WithInitialFeatureSupport;MonoFond;MFBRepVersion_CXR15)", pad1)

Set geometricElements3 = factory2D2.CreateProjections(reference13)

Set geometry2D1 = geometricElements3.Item("Empreinte.1")

geometry2D1.Construction = True

Set reference14 = part1.CreateReferenceFromBRepName("FEdge:(Edge:(Face:(Brp:(Pad.1;0:(Brp:(Sketch.1;8)));None:();Cf11:());Face:(Brp:(Pad.1;2);None:();Cf11:());None:(Limits1:();Limits2:());Cf11:());WithPermanentBody;WithoutBuildError;WithInitialFeatureSupport;MonoFond;MFBRepVersion_CXR15)", pad1)

Set geometricElements4 = factory2D2.CreateProjections(reference14)

Set geometry2D2 = geometricElements4.Item("Empreinte.1")

geometry2D2.Construction = True

/*********************************/
/* init constraints2 for sketch2 */
/*********************************/

Set constraints2 = sketch2.Constraints

/********************************/
/* set constraints2 for sketch1 */
/********************************/

Set reference15 = part1.CreateReferenceFromObject(geometry2D1)

Set reference16 = part1.CreateReferenceFromObject(geometry2D2)

Set reference17 = part1.CreateReferenceFromObject(point2D5)

Set constraint7 = constraints2.AddTriEltCst(catCstTypeEquidistance, reference15, reference16, reference17)

constraint7.Mode = catCstModeDrivingDimension

Set reference18 = part1.CreateReferenceFromBRepName("FEdge:(Edge:(Face:(Brp:(Pad.1;0:(Brp:(Sketch.1;9)));None:();Cf11:());Face:(Brp:(Pad.1;0:(Brp:(Sketch.1;8)));None:();Cf11:());None:(Limits1:();Limits2:());Cf11:());WithPermanentBody;WithoutBuildError;WithInitialFeatureSupport;MonoFond;MFBRepVersion_CXR15)", pad1)

Set geometricElements5 = factory2D2.CreateProjections(reference18)

Set geometry2D3 = geometricElements5.Item("Empreinte.1")

geometry2D3.Construction = True

Set reference19 = part1.CreateReferenceFromBRepName("FEdge:(Edge:(Face:(Brp:(Pad.1;0:(Brp:(Sketch.1;8)));None:();Cf11:());Face:(Brp:(Pad.1;0:(Brp:(Sketch.1;6)));None:();Cf11:());None:(Limits1:();Limits2:());Cf11:());WithPermanentBody;WithoutBuildError;WithInitialFeatureSupport;MonoFond;MFBRepVersion_CXR15)", pad1)

Set geometricElements6 = factory2D2.CreateProjections(reference19)

Set geometry2D4 = geometricElements6.Item("Empreinte.1")

geometry2D4.Construction = True

Set reference20 = part1.CreateReferenceFromObject(geometry2D3)

Set reference21 = part1.CreateReferenceFromObject(geometry2D4)

Set reference22 = part1.CreateReferenceFromObject(point2D5)

Set constraint8 = constraints2.AddTriEltCst(catCstTypeEquidistance, reference20, reference21, reference22)

constraint8.Mode = catCstModeDrivingDimension

/***********************/
/* end edition sketch2 */
/***********************/

sketch2.CloseEdition 

part1.InWorkObject = sketch2

part1.Update 

Set reference23 = part1.CreateReferenceFromBRepName("BorderFVertex:(BEdge:(Brp:(Sketch.2;3);None:(Limits1:();Limits2:();+1);Cf11:());WithTemporaryBody;WithoutBuildError;WithSelectingFeatureSupport;MFBRepVersion_CXR15)", sketch2)

Set reference24 = part1.CreateReferenceFromBRepName("FSur:(Face:(Brp:(Pad.1;0:(Brp:(Sketch.1;8)));None:();Cf11:());WithTemporaryBody;WithoutBuildError;WithInitialFeatureSupport;MonoFond;MFBRepVersion_CXR15)", pad1)

/**************/
/* init hole1 */
/**************/

Set hole1 = shapeFactory1.AddNewHoleFromRefPoint(reference23, reference24, 10.000000)

/*************/
/* set hole1 */
/*************/

hole1.Type = catSimpleHole

hole1.AnchorMode = catExtremPointHoleAnchor

hole1.BottomType = catFlatHoleBottom

Set limit2 = hole1.BottomLimit

limit2.LimitMode = catOffsetLimit

Set length4 = hole1.Diameter

length4.Value = 10.000000

hole1.ThreadingMode = catSmoothHoleThreading

hole1.ThreadSide = catRightThreadSide

part1.Update 

End Sub
