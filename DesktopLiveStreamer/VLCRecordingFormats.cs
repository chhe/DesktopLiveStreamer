using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesktopLiveStreamer {
    class VLCRecordingFormats {

        public static VLCRecordingFormats OGG = new VLCRecordingFormats("OGG", "ogg", "ogg");

        public static VLCRecordingFormats PS = new VLCRecordingFormats("MPEG-PS", "ps", "mpg");

        public static VLCRecordingFormats TS = new VLCRecordingFormats("MPEG-TS", "ts", "mpg");

        public String MenuEntry { get; private set; }
        public String Muxer { get; private set; }
        public String Extension { get; private set; }

        private static List<VLCRecordingFormats> entries = new List<VLCRecordingFormats>();

        static VLCRecordingFormats() {
            entries.Add(OGG);
            entries.Add(PS);
            entries.Add(TS);
        }

        public static List<VLCRecordingFormats> getEntries() {
            return entries;
        }

        public static VLCRecordingFormats getValueFromMenuEntry(String menuEntry) {
            foreach (VLCRecordingFormats format in getEntries()) {
                if (format.MenuEntry.Equals(menuEntry)) {
                    return format;
                }
            }
            return OGG;
        }

        public VLCRecordingFormats(string menuEntry, string muxer, string extension) {
            this.MenuEntry = menuEntry;
            this.Muxer = muxer;
            this.Extension = extension;
        }
    }
}
