using CommandLine;

namespace SVGConvert
{
    public class Options
    {
        [Option('f', "format", Required = false, Default = "png", HelpText = "Output File Format ( jpg | png ).")]
        public string Format { get; set; }
        [Option('h', "height", Required = true, HelpText = "Height of output image in pixels.")]
        public int Height { get; set; }
        [Option('v', "verbose", Required = false, HelpText = "Set output to verbose messages.")]
        public bool Verbose { get; set; }
        [Option('s', "source", Required = true, HelpText = "Source filename.")]
        public string Source { get; set; }
        [Option('t', "target", Required = true, HelpText = "Target filename.")]
        public string Target { get; set; }
        [Option('w', "width", Required = true, HelpText = "Width of output image in pixels.")]
        public int Width { get; set; }

    }
}
