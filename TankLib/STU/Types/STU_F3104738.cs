// Instance generated by TankLibHelper.InstanceBuilder

// ReSharper disable All
namespace TankLib.STU.Types {
    [STUAttribute(0xF3104738)]
    public class STU_F3104738 : STUStatescriptState {
        [STUFieldAttribute(0x68666D2D, "m_hitReactions", ReaderType = typeof(InlineInstanceFieldReader))]
        public STUAIHitReaction[] m_hitReactions;

        [STUFieldAttribute(0x85FF200D, "m_bodyPartDamageGroups", ReaderType = typeof(InlineInstanceFieldReader))]
        public STUAIBodyPartDamageGroup[] m_bodyPartDamageGroups;

        [STUFieldAttribute(0x51EFC23E, ReaderType = typeof(InlineInstanceFieldReader))]
        public STU_0912964B[] m_51EFC23E;

        [STUFieldAttribute(0xB223A14E, ReaderType = typeof(EmbeddedInstanceFieldReader))]
        public STUConfigVar m_B223A14E;
    }
}