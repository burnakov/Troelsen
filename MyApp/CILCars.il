// �������� ������ �� mscorlib.dll � System.Windows.Forms.dll.
.assembly extern mscorlib
{
.publickeytoken = (B7 7A 5C 56 19 34 E0 89 )
.ver 4 : 0:0:0
}
.assembly extern System.Windows.Forms
{
.publickeytoken = (B7 7A 5C 56 19 34 E0 89 )
.ver 4 : 0 : 0:0
}
// ���������� ������������ ������.
.assembly CILCars
{
.hash algorithm 0x00008004
.ver 1:0:0 : 0
}
.module CILCars.dll

.namespace CILCars
{
	.class public auto ansi beforefieldinit CILCar
		extends [mscorlib]System.Object
	{
		// ���� ������ CILCar.
		.field public string petName
		.field public int32 currSpeed
		// ����������� ����������� ������ ���������
		// ����������� ���� ����������� ���� ������.
		.method public hidebysig specialname rtspecialname
			instance void .ctor(int32 c, string p) cil managed
		{
			.maxstack 8
			// ��������� ������ �������� � ���� � ������� ����������� �������� ������.
			ldarg.0 // ������ this, � �� int32!
			call instance void [mscorlib]System.Object::.ctor()
			// ��������� ������ � ������ ��������� � ����.
			ldarg.0	//	������ this
			ldarg.1	//	�������� int32
			// ��������� ����� ������� ������� ����� (int 32) � ���� currSpeed.
			stfld int32 CILCars.CILCar::currSpeed
			// ��������� ��������� �������� � ��������� � ���� petName.
			ldarg.0	//	������ this
			ldarg.2	//	�������� string
			stfld string CILCars.CILCar::petName
			ret
		}
	}

	.class public auto ansi beforefieldinit CILCarInfo
		extends [mscorlib]System.Object
	{
		.method public hidebysig static void
			Display(class CILCars.CILCar c) cil managed
		{
			.maxstack 8
			// ��� ����� ��������� ��������� ����������.
			.locals init ([0] string caption)
			// �������� ������ � �������� ��������� CILCar � ����.
			ldstr "{0}'s speed is:"
			ldarg.0
			// ��������� � ���� �������� ���� petName �� CILCar
			// � ������� ����������� ����� String.Format() .
			ldfld string CILCars.CILCar::petName
			call string [mscorlib]System.String::Format(string, object)
			stloc.0
			// ��������� �������� ���� currSpeed � �������� ��� ���������
			// ������������� (�������� �������� �� ����� ToString()).
			ldarg.0
			ldflda int32 CILCars.CILCar::currSpeed
			call instance string [mscorlib]System.Int32::ToString()
			ldloc.0
			// ������� ����� MessageBox.Show() � ������������ ����������.
			call valuetype [System.Windows.Forms]System.Windows.Forms.DialogResult
				[System.Windows.Forms]System.Windows.Forms.MessageBox::Show(string, string)
			pop
			ret
		}		
	}
}