﻿namespace H.NotifyIcon;

/// <inheritdoc/>
public partial class TaskbarIcon
{
    #region Constants

    /// <summary>
    /// Category name that is set on designer properties.
    /// </summary>
    public const string GeneratedIconCategoryName = "NotifyIcon GeneratedIcon";

    #endregion

    #region Properties

    #region Text

    /// <summary>Identifies the <see cref="GeneratedIconText"/> dependency property.</summary>
    public static readonly DependencyProperty GeneratedIconTextProperty =
        DependencyProperty.Register(
            nameof(GeneratedIconText),
            typeof(string),
            typeof(TaskbarIcon),
            new PropertyMetadata(string.Empty, (d, _) => ((TaskbarIcon)d).RefreshGeneratedIcon()));

    /// <summary>
    /// A property wrapper for the <see cref="GeneratedIconTextProperty"/>
    /// dependency property:<br/>
    /// Defines generated icon text.
    /// Defaults to string.Empty.
    /// </summary>
    [Category(GeneratedIconCategoryName)]
    [Description("Defines generated icon text.")]
#if HAS_WPF
    [Localizability(LocalizationCategory.Text)]
#endif
    public string? GeneratedIconText
    {
        get { return (string?)GetValue(GeneratedIconTextProperty); }
        set { SetValue(GeneratedIconTextProperty, value); }
    }

    #endregion

    #region Margin

    /// <summary>Identifies the <see cref="GeneratedIconMargin"/> dependency property.</summary>
    public static readonly DependencyProperty GeneratedIconMarginProperty =
        DependencyProperty.Register(
            nameof(GeneratedIconMargin),
            typeof(Thickness),
            typeof(TaskbarIcon),
            new PropertyMetadata(default(Thickness), (d, _) => ((TaskbarIcon)d).RefreshGeneratedIcon()));

    /// <summary>
    /// A property wrapper for the <see cref="GeneratedIconMarginProperty"/>
    /// dependency property:<br/>
    /// Defines generated icon margin.
    /// Defaults to (0,0,0,0).
    /// </summary>
    [Category(GeneratedIconCategoryName)]
    [Description("Defines generated icon margin.")]
    public Thickness GeneratedIconMargin
    {
        get { return (Thickness)GetValue(GeneratedIconMarginProperty); }
        set { SetValue(GeneratedIconMarginProperty, value); }
    }

    #endregion

    #region BackgroundType

    /// <summary>Identifies the <see cref="GeneratedIconBackgroundType"/> dependency property.</summary>
    public static readonly DependencyProperty GeneratedIconBackgroundTypeProperty =
        DependencyProperty.Register(
            nameof(GeneratedIconBackgroundType),
            typeof(BackgroundType),
            typeof(TaskbarIcon),
            new PropertyMetadata(default(BackgroundType), (d, _) => ((TaskbarIcon)d).RefreshGeneratedIcon()));

    /// <summary>
    /// A property wrapper for the <see cref="GeneratedIconBackgroundTypeProperty"/>
    /// dependency property:<br/>
    /// Defines generated icon background type.
    /// Defaults to Ellipse.
    /// </summary>
    [Category(GeneratedIconCategoryName)]
    [Description("Defines generated icon background type.")]
    public BackgroundType GeneratedIconBackgroundType
    {
        get { return (BackgroundType)GetValue(GeneratedIconBackgroundTypeProperty); }
        set { SetValue(GeneratedIconBackgroundTypeProperty, value); }
    }

    #endregion

    #region TextMargin

    /// <summary>Identifies the <see cref="GeneratedIconTextMargin"/> dependency property.</summary>
    public static readonly DependencyProperty GeneratedIconTextMarginProperty =
        DependencyProperty.Register(
            nameof(GeneratedIconTextMargin),
            typeof(Thickness),
            typeof(TaskbarIcon),
            new PropertyMetadata(default(Thickness), (d, _) => ((TaskbarIcon)d).RefreshGeneratedIcon()));

    /// <summary>
    /// A property wrapper for the <see cref="GeneratedIconTextMarginProperty"/>
    /// dependency property:<br/>
    /// Defines generated icon text margin.
    /// Defaults to (0,0,0,0).
    /// </summary>
    [Category(GeneratedIconCategoryName)]
    [Description("Defines generated icon text margin.")]
    public Thickness GeneratedIconTextMargin
    {
        get { return (Thickness)GetValue(GeneratedIconTextMarginProperty); }
        set { SetValue(GeneratedIconTextMarginProperty, value); }
    }

    #endregion

    #region CornerRadius

    /// <summary>Identifies the <see cref="GeneratedIconCornerRadius"/> dependency property.</summary>
    public static readonly DependencyProperty GeneratedIconCornerRadiusProperty =
        DependencyProperty.Register(
            nameof(GeneratedIconCornerRadius),
            typeof(CornerRadius),
            typeof(TaskbarIcon),
            new PropertyMetadata(default(CornerRadius), (d, _) => ((TaskbarIcon)d).RefreshGeneratedIcon()));

    /// <summary>
    /// A property wrapper for the <see cref="GeneratedIconCornerRadiusProperty"/>
    /// dependency property:<br/>
    /// Defines generated icon corner radius.
    /// Defaults to (0,0,0,0).
    /// </summary>
    [Category(GeneratedIconCategoryName)]
    [Description("Defines generated icon corner radius.")]
    public CornerRadius GeneratedIconCornerRadius
    {
        get { return (CornerRadius)GetValue(GeneratedIconCornerRadiusProperty); }
        set { SetValue(GeneratedIconCornerRadiusProperty, value); }
    }

    #endregion

    #region Foreground

    /// <summary>Identifies the <see cref="GeneratedIconForeground"/> dependency property.</summary>
    public static readonly DependencyProperty GeneratedIconForegroundProperty =
        DependencyProperty.Register(
            nameof(GeneratedIconForeground),
            typeof(Brush),
            typeof(TaskbarIcon),
            new PropertyMetadata(
#if HAS_WPF
                Brushes.Black,
#else
                new SolidColorBrush(Colors.Black),
#endif
                (d, _) => ((TaskbarIcon)d).RefreshGeneratedIcon()));

    /// <summary>
    /// A property wrapper for the <see cref="GeneratedIconForegroundProperty"/>
    /// dependency property:<br/>
    /// Defines generated icon foreground.
    /// Defaults to Brushes.Black.
    /// </summary>
    [Category(GeneratedIconCategoryName)]
    [Description("Defines generated icon foreground.")]
    public Brush? GeneratedIconForeground
    {
        get { return (Brush?)GetValue(GeneratedIconForegroundProperty); }
        set { SetValue(GeneratedIconForegroundProperty, value); }
    }

    #endregion

    #region Background

    /// <summary>Identifies the <see cref="GeneratedIconBackground"/> dependency property.</summary>
    public static readonly DependencyProperty GeneratedIconBackgroundProperty =
        DependencyProperty.Register(
            nameof(GeneratedIconBackground),
            typeof(Brush),
            typeof(TaskbarIcon),
            new PropertyMetadata(null, (d, _) => ((TaskbarIcon)d).RefreshGeneratedIcon()));

    /// <summary>
    /// A property wrapper for the <see cref="GeneratedIconBackgroundProperty"/>
    /// dependency property:<br/>
    /// Defines generated icon background.
    /// Defaults to null.
    /// </summary>
    [Category(GeneratedIconCategoryName)]
    [Description("Defines generated icon background.")]
    public Brush? GeneratedIconBackground
    {
        get { return (Brush?)GetValue(GeneratedIconBackgroundProperty); }
        set { SetValue(GeneratedIconBackgroundProperty, value); }
    }

    #endregion

    #region FontFamily

    /// <summary>Identifies the <see cref="GeneratedIconFontFamily"/> dependency property.</summary>
    public static readonly DependencyProperty GeneratedIconFontFamilyProperty =
        DependencyProperty.Register(
            nameof(GeneratedIconFontFamily),
            typeof(FontFamily),
            typeof(TaskbarIcon),
            new PropertyMetadata(
#if HAS_WPF
                SystemFonts.IconFontFamily,
#else
                new FontFamily("Segoe UI"),
#endif
                (d, _) => ((TaskbarIcon)d).RefreshGeneratedIcon()));

    /// <summary>
    /// A property wrapper for the <see cref="GeneratedIconFontFamilyProperty"/>
    /// dependency property:<br/>
    /// Defines generated icon font size.
    /// Defaults to SystemFonts.IconFontSize.
    /// </summary>
    [Category(GeneratedIconCategoryName)]
    [Description("Defines generated icon font family.")]
#if HAS_WPF
    [Localizability(LocalizationCategory.Font)]
#endif
    public FontFamily? GeneratedIconFontFamily
    {
        get { return (FontFamily?)GetValue(GeneratedIconFontFamilyProperty); }
        set { SetValue(GeneratedIconFontFamilyProperty, value); }
    }

    #endregion

    #region FontStyle

    /// <summary>Identifies the <see cref="GeneratedIconFontStyle"/> dependency property.</summary>
    public static readonly DependencyProperty GeneratedIconFontStyleProperty =
        DependencyProperty.Register(
            nameof(GeneratedIconFontStyle),
            typeof(FontStyle),
            typeof(TaskbarIcon),
            new PropertyMetadata(
#if HAS_WPF
                SystemFonts.IconFontStyle,
#else
                FontStyle.Normal,
#endif
                (d, _) => ((TaskbarIcon)d).RefreshGeneratedIcon()));

    /// <summary>
    /// A property wrapper for the <see cref="GeneratedIconFontStyleProperty"/>
    /// dependency property:<br/>
    /// Defines generated icon font style.
    /// Defaults to SystemFonts.IconFontStyle.
    /// </summary>
    [Category(GeneratedIconCategoryName)]
    [Description("Defines generated icon font style.")]
    public FontStyle GeneratedIconFontStyle
    {
        get { return (FontStyle)GetValue(GeneratedIconFontStyleProperty); }
        set { SetValue(GeneratedIconFontStyleProperty, value); }
    }

    #endregion

    #region FontWeight

    /// <summary>Identifies the <see cref="GeneratedIconFontWeight"/> dependency property.</summary>
    public static readonly DependencyProperty GeneratedIconFontWeightProperty =
        DependencyProperty.Register(
            nameof(GeneratedIconFontWeight),
            typeof(FontWeight),
            typeof(TaskbarIcon),
            new PropertyMetadata(
#if HAS_WPF
                SystemFonts.IconFontWeight,
#else
                FontWeights.Normal,
#endif
                (d, _) => ((TaskbarIcon)d).RefreshGeneratedIcon()));

    /// <summary>
    /// A property wrapper for the <see cref="GeneratedIconFontWeightProperty"/>
    /// dependency property:<br/>
    /// Defines generated icon font weight.
    /// Defaults to SystemFonts.IconFontWeight.
    /// </summary>
    [Category(GeneratedIconCategoryName)]
    [Description("Defines generated icon font weight.")]
    public FontWeight GeneratedIconFontWeight
    {
        get { return (FontWeight)GetValue(GeneratedIconFontWeightProperty); }
        set { SetValue(GeneratedIconFontWeightProperty, value); }
    }

    #endregion

    #region FontStretch

    /// <summary>Identifies the <see cref="GeneratedIconFontStretch"/> dependency property.</summary>
    public static readonly DependencyProperty GeneratedIconFontStretchProperty =
        DependencyProperty.Register(
            nameof(GeneratedIconFontStretch),
            typeof(FontStretch),
            typeof(TaskbarIcon),
            new PropertyMetadata(
#if HAS_WPF
                FontStretches.Normal,
#else
                FontStretch.Normal,
#endif
                (d, _) => ((TaskbarIcon)d).RefreshGeneratedIcon()));

    /// <summary>
    /// A property wrapper for the <see cref="GeneratedIconFontStretchProperty"/>
    /// dependency property:<br/>
    /// Defines generated icon font stretch.
    /// Defaults to FontStretches.Normal.
    /// </summary>
    [Category(GeneratedIconCategoryName)]
    [Description("Defines generated icon font stretch.")]
    public FontStretch GeneratedIconFontStretch
    {
        get { return (FontStretch)GetValue(GeneratedIconFontStretchProperty); }
        set { SetValue(GeneratedIconFontStretchProperty, value); }
    }

    #endregion

    #region FontSize

    /// <summary>Identifies the <see cref="GeneratedIconFontSize"/> dependency property.</summary>
    public static readonly DependencyProperty GeneratedIconFontSizeProperty =
        DependencyProperty.Register(
            nameof(GeneratedIconFontSize),
            typeof(double),
            typeof(TaskbarIcon),
            new PropertyMetadata(
#if HAS_WPF
                4 * SystemFonts.IconFontSize,
#else
                4 * 12.0,
#endif
                (d, _) => ((TaskbarIcon)d).RefreshGeneratedIcon()));

    /// <summary>
    /// A property wrapper for the <see cref="GeneratedIconFontSizeProperty"/>
    /// dependency property:<br/>
    /// Defines generated icon font size.
    /// Defaults to SystemFonts.IconFontSize.
    /// </summary>
    [Category(GeneratedIconCategoryName)]
    [Description("Defines generated icon font size.")]
#if HAS_WPF
    [Localizability(LocalizationCategory.None)]
    [TypeConverter(typeof(FontSizeConverter))]
#endif
    public double GeneratedIconFontSize
    {
        get { return (double)GetValue(GeneratedIconFontSizeProperty); }
        set { SetValue(GeneratedIconFontSizeProperty, value); }
    }

    #endregion

    #region Icon

    /// <summary>Identifies the <see cref="GeneratedIcon"/> dependency property.</summary>
    public static readonly DependencyProperty GeneratedIconProperty =
        DependencyProperty.Register(nameof(GeneratedIcon),
            typeof(System.Drawing.Icon),
            typeof(TaskbarIcon),
            new PropertyMetadata(null, GeneratedIconChanged));

    /// <summary>
    /// Gets or sets the icon to be displayed.
    /// Use this for dynamically generated System.Drawing.Icons.
    /// </summary>
    [Category(GeneratedIconCategoryName)]
    [Description("Defines generated icon.")]
    public System.Drawing.Icon? GeneratedIcon
    {
        get => (System.Drawing.Icon?)GetValue(GeneratedIconProperty);
        set => SetValue(GeneratedIconProperty, value);
    }

    private static void GeneratedIconChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
    {
        if (d is not TaskbarIcon control)
        {
            throw new InvalidOperationException($"Parent should be {nameof(TaskbarIcon)}");
        }
        if (e.OldValue is System.Drawing.Icon oldIcon)
        {
            oldIcon.Dispose();
        }
        var newIcon = (System.Drawing.Icon?)e.NewValue;

        var icon = newIcon?.Handle ?? IntPtr.Zero;

        control.TrayIcon.UpdateIcon(icon);
    }

    #endregion

    #region Size

    /// <summary>Identifies the <see cref="GeneratedIconSize"/> dependency property.</summary>
    public static readonly DependencyProperty GeneratedIconSizeProperty =
        DependencyProperty.Register(
            nameof(GeneratedIconSize),
            typeof(int),
            typeof(TaskbarIcon),
            new PropertyMetadata(
                128,
                (d, _) => ((TaskbarIcon)d).RefreshGeneratedIcon()));

    /// <summary>
    /// A property wrapper for the <see cref="GeneratedIconSizeProperty"/>
    /// dependency property:<br/>
    /// Defines generated icon size.
    /// Defaults to 128.
    /// </summary>
    [Category(GeneratedIconCategoryName)]
    [Description("Defines generated icon size.")]
    public int GeneratedIconSize
    {
        get { return (int)GetValue(GeneratedIconSizeProperty); }
        set { SetValue(GeneratedIconSizeProperty, value); }
    }

    #endregion

    #region BorderThickness

    /// <summary>Identifies the <see cref="GeneratedIconBorderThickness"/> dependency property.</summary>
    public static readonly DependencyProperty GeneratedIconBorderThicknessProperty =
        DependencyProperty.Register(
            nameof(GeneratedIconBorderThickness),
            typeof(float),
            typeof(TaskbarIcon),
            new PropertyMetadata(
                0.0F,
                (d, _) => ((TaskbarIcon)d).RefreshGeneratedIcon()));

    /// <summary>
    /// A property wrapper for the <see cref="GeneratedIconBorderThicknessProperty"/>
    /// dependency property:<br/>
    /// Defines generated icon border thickness.
    /// Defaults to 0.
    /// </summary>
    [Category(GeneratedIconCategoryName)]
    [Description("Defines generated icon border thickness.")]
    public float GeneratedIconBorderThickness
    {
        get { return (float)GetValue(GeneratedIconBorderThicknessProperty); }
        set { SetValue(GeneratedIconBorderThicknessProperty, value); }
    }

    #endregion

    #region BorderBrush

    /// <summary>Identifies the <see cref="GeneratedIconBorderBrush"/> dependency property.</summary>
    public static readonly DependencyProperty GeneratedIconBorderBrushProperty =
        DependencyProperty.Register(
            nameof(GeneratedIconBorderBrush),
            typeof(Brush),
            typeof(TaskbarIcon),
            new PropertyMetadata(
#if HAS_WPF
                Brushes.Black,
#else
                new SolidColorBrush(Colors.Black),
#endif
                (d, _) => ((TaskbarIcon)d).RefreshGeneratedIcon()));

    /// <summary>
    /// A property wrapper for the <see cref="GeneratedIconBorderBrushProperty"/>
    /// dependency property:<br/>
    /// Defines generated icon border brush.
    /// Defaults to Black.
    /// </summary>
    [Category(GeneratedIconCategoryName)]
    [Description("Defines generated icon border brush.")]
    public Brush? GeneratedIconBorderBrush
    {
        get { return (Brush?)GetValue(GeneratedIconBorderBrushProperty); }
        set { SetValue(GeneratedIconBorderBrushProperty, value); }
    }

    #endregion

    #endregion

    #region Methods

    private void RefreshGeneratedIcon()
    {
        var size = GeneratedIconSize;
        using var fontFamily =
            GeneratedIconFontFamily?.ToSystemDrawingFontFamily() ??
            new System.Drawing.FontFamily(string.Empty);
        using var font = new System.Drawing.Font(
            fontFamily,
            (float)GeneratedIconFontSize,
            GeneratedIconFontStyle.ToSystemDrawingFontStyle(GeneratedIconFontWeight));
        using var baseImage = Icon?.ToBitmap();
        using var pen = GeneratedIconBorderBrush.ToSystemDrawingPen(GeneratedIconBorderThickness);
        using var backgroundBrush = GeneratedIconBackground.ToSystemDrawingBrush();
        using var foregroundBrush = GeneratedIconForeground.ToSystemDrawingBrush();

        GeneratedIcon = IconGenerator.Generate(
            backgroundBrush: backgroundBrush,
            foregroundBrush: foregroundBrush,
            pen: GeneratedIconBorderThickness > 0.01F
                ? pen
                : null,
            backgroundType: GeneratedIconBackgroundType,
            cornerRadius: (float)GeneratedIconCornerRadius.TopLeft,
            rectangle: GeneratedIconMargin == default
                ? null
                : GeneratedIconMargin.ToSystemDrawingRectangleF(width: size, height: size),
            text: GeneratedIconText,
            font: font,
            textRectangle: GeneratedIconTextMargin == default
                ? null
                : GeneratedIconTextMargin.ToSystemDrawingRectangleF(width: size, height: size),
            baseImage: baseImage,
            size: size);
    }

    #endregion
}
