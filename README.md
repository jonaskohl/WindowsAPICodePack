This is a version of the *Microsoft Windows API Code Pack 1.1* which has [the following fix applied](https://stackoverflow.com/a/12061807) to it:

In [NativeTaskDialog.cs](Core/Interop/TaskDialogs/NativeTaskDialog.cs) there is a bug where on a 64-bit system, adding buttons to the `TaskDialog` may result in
a `System.OverflowException`. To fix this, line 533 has been altered from:

```csharp
currentPtr = (IntPtr)((int)currentPtr + Marshal.SizeOf(button));
```

...to:

```csharp
currentPtr = (IntPtr)(currentPtr.ToInt64() + Marshal.SizeOf(button));
```
