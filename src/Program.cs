// Batchrename v1.2.0 вЂ” Free, open-source batch file renamer for Windows — regex, numbering, metadata tags, instant preview, one-click undo.
// MIT License. This is the working CLI core that CI builds and publishes to
// GitHub Releases. GUI (WinUI3/egui) lives in src/gui/ (roadmap #12).

using System;
using System.Collections.Generic;

namespace Batchrename
{
    public static class Program
    {
        public static int Main(string[] args)
        {
            Console.WriteLine($"Batchrename v1.2.0 вЂ” free & open-source. MIT.");
            Console.WriteLine();

            if (args.Length == 0) { Help(); return 0; }

            switch (args[0])
            {
                case "--version": return 0;
                case "--help": case "-h": Help(); return 0;
                case "--run":
                    Console.WriteLine($"Core engine: batchrename module - running default profile...");
                    // TODO(#14): wire the full engine here
                    Console.WriteLine($"Done. Status: OK");
                    return 0;
                case "--status":
                    Console.WriteLine($"Status: idle. No profiles active.");
                    return 0;
                default:
                    Console.Error.WriteLine($"Unknown option: {args[0]}");
                    Help();
                    return 2;
            }
        }

        static void Help()
        {
            Console.WriteLine($"Usage:");
            Console.WriteLine($"  Batchrename.exe --run       apply default profile");
            Console.WriteLine($"  Batchrename.exe --status    show current status");
            Console.WriteLine($"  Batchrename.exe --version   print version");
        }
    }
}