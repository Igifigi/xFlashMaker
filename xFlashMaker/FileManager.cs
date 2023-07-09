using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace xFlashMaker
{
    internal class FileManager
    {
        private static string generate_json(IEnumerable<Flashcard> flashcards)
        {
            return JsonConvert.SerializeObject(flashcards, Formatting.Indented);
        }

        private static IEnumerable<Flashcard> decode_json(string json)
        {
            return JsonConvert.DeserializeObject<IEnumerable<Flashcard>>(json);
        }

        public static void export_flashcards_as_fcs(IEnumerable<Flashcard> flashcards)
        {
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Filter = "Flashcards file|*.fcs";
            dialog.Title = "Export flashcards";
            dialog.FileName = "flashcards";
            if (dialog.ShowDialog() == DialogResult.OK)
                File.WriteAllText(dialog.FileName, generate_json(flashcards));
        }

        public static IEnumerable<Flashcard> import_flashcards_from_fcs()
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Flashcards file|*.fcs";
            dialog.Title = "Import flashcards";
            if (dialog.ShowDialog() == DialogResult.OK)
                return decode_json(File.ReadAllText(dialog.FileName));
            return null;
        } 

    }
}
