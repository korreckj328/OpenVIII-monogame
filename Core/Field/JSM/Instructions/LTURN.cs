﻿namespace OpenVIII.Fields.Scripts.Instructions
{
    internal sealed class LTURN : JsmInstruction
    {
        #region Fields

        private readonly IJsmExpression _arg0;
        private readonly IJsmExpression _arg1;

        #endregion Fields

        #region Constructors

        public LTURN(IJsmExpression arg0, IJsmExpression arg1)
        {
            _arg0 = arg0;
            _arg1 = arg1;
        }

        public LTURN(int parameter, IStack<IJsmExpression> stack)
            : this(
                arg1: stack.Pop(),
                arg0: stack.Pop())
        {
        }

        #endregion Constructors

        #region Methods

        public override string ToString() => $"{nameof(LTURN)}({nameof(_arg0)}: {_arg0}, {nameof(_arg1)}: {_arg1})";

        #endregion Methods
    }
}