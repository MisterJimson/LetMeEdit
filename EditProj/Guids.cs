// Guids.cs
// MUST match guids.h

using System;

namespace LetMeEdit
{
    static class GuidList
    {
        public const string guidEditProjPkgString = "e6731de7-78c4-45f9-bce0-e66023e6dcc2";
        public static Guid EditProjCmdSetId => Guid.Parse("d2f70dae-9a2d-47e1-a470-7354a552821c");
        public static Guid EditSlnCmdSetId => Guid.Parse("4cad5c42-61dd-47f9-a605-bb9c469dc962");
    };
}