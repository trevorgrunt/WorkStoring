using System;

public class Main
{
	private List<Industry>_industria; 
	private void Industry()
	{
		_industria = new List<Industry>
		{
			new Industry {name, god, studio, price, tir, razr}
		};
	}

	private void Start()
    {
		Industry();
		_text.text = string.Join(Environment.NewLine, _industria);
	}
}
