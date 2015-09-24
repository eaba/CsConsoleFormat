﻿using System;

namespace Alba.CsConsoleFormat.Generation
{
    public sealed class ElementBuilder<T> : IElementBuilder<T>
        where T : Element, new()
    {
        public T Element { get; }

        public ElementBuilder (T element)
        {
            Element = element;
        }

        Element IElementBuilder.Element => Element;
        Type IElementBuilder.ElementType => typeof(T);

        public static implicit operator T (ElementBuilder<T> @this) => @this.Element;
    }
}