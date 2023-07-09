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
        private static List<Flashcard> empty_collection = new List<Flashcard>();
        private static void show_error(string error)
        {
            MessageBox.Show(string.Format("An error occured: {0}", error), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
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
            try
            {
                if (dialog.ShowDialog() != DialogResult.OK)
                    return;
                File.WriteAllText(dialog.FileName, generate_json(flashcards));
            }
            catch (Exception e)
            {
                show_error(e.Message);
            }
        }

        public static IEnumerable<Flashcard> import_flashcards_from_fcs()
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Flashcards file|*.fcs";
            dialog.Title = "Import flashcards";
            try
            {
                if (dialog.ShowDialog() != DialogResult.OK)
                    return empty_collection;
                return decode_json(File.ReadAllText(dialog.FileName));
            }
            catch (Exception e)
            {
                show_error(e.Message);
            }
            return empty_collection;
        }

        public static void export_flashcards_as_csv(IEnumerable<Flashcard> flashcards)
        {
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Filter = "Comma separated values file|*.csv";
            dialog.Title = "Export flashcards";
            dialog.FileName = "flashcards";

            StringBuilder export = new StringBuilder();
            foreach (Flashcard flashcard in flashcards)
            {
                string[] line = { flashcard.term, flashcard.definition };
                export.AppendLine(string.Join(",", line));
            }
            try
            {
                if (dialog.ShowDialog() != DialogResult.OK)
                    return;
                File.WriteAllText(dialog.FileName, export.ToString());
            }
            catch (Exception e)
            {
                show_error(e.Message);
            }
        }

        public static IEnumerable<Flashcard> import_flashcards_from_csv()
        {
            List<Flashcard> import = new List<Flashcard>();

            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Comma separated values file|*.csv";
            dialog.Title = "Import flashcards";

            try
            {
                if (dialog.ShowDialog() != DialogResult.OK)
                    return empty_collection;

                StreamReader reader = new StreamReader(dialog.FileName);
                while (!reader.EndOfStream)
                {
                    string line = reader.ReadLine();
                    string[] values = line.Split(',');
                    if (values.Length != 2)
                        show_error("Data not valid");
                    else
                    {
                        try
                        {
                            import.Add(new Flashcard(values[0], values[1]));
                        }
                        catch (Exception e)
                        {
                            show_error(e.Message);
                        }
                    }
                }
                return import;
            }
            catch (Exception e)
            {
                show_error(e.Message);
            }
            return empty_collection;
        }
    }
}
