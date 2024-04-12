using System.Text.Json;

namespace Anket2.Models;

public static class JsonMethods
{
	public static byte Write(List<User> users, string fileName)
	{
		try
		{
			JsonSerializerOptions op = new() { WriteIndented = true };

			File.WriteAllText($"{fileName}", JsonSerializer.Serialize<List<User>>(users, op));
			return 1;
		}
		catch { return 2; }
	}

	public static List<User>? Read(string fileName)
	{
		if (File.Exists($"{fileName}") == false)
			return null;

		try
		{
			JsonSerializerOptions op = new() { WriteIndented = true };

			return JsonSerializer.Deserialize<List<User>>(File.ReadAllText($"{fileName}"));
		}
		catch { return null; }
	}

}
