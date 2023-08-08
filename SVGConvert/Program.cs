// See https://aka.ms/new-console-template for more information
using CommandLine;
using SVGConvert;

Console.WriteLine("SVG Converter");

Parser.Default.ParseArguments<Options>(args)
       .WithParsed<Options>(o =>
       {
           switch(o.Format.ToLower())
           {
               case "jpg":
                   Console.WriteLine("Converting {0} to {1} as {2} ( {3} x {4} )", o.Source, o.Target, o.Format.ToLower(), o.Width, o.Height);
                   SVGConverter.SvgToJpg(o.Source, o.Target, o.Width, o.Height);
                   break;
               case "png":
                   Console.WriteLine("Converting {0} to {1} as {2} ( {3} x {4} )", o.Source, o.Target, o.Format.ToLower(), o.Width, o.Height);
                   SVGConverter.SvgToPng(o.Source, o.Target, o.Width, o.Height);
                   break;
               default:
                   Console.WriteLine("Invalid format.  Must be jpg or png.");
                   return;
           }
       });