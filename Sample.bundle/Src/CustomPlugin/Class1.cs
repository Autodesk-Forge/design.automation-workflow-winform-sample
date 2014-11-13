using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

using Autodesk.AutoCAD.Runtime; 
using Autodesk.AutoCAD.EditorInput; 
using Autodesk.AutoCAD.DatabaseServices; 
using Autodesk.AutoCAD.ApplicationServices; 
using Autodesk.AutoCAD.Geometry;
using Autodesk.AutoCAD.GraphicsInterface;

namespace CustomPlugin
{
    public class MyCommands
    {
        #region Change Attribute
        [CommandMethod("ChangeAttr")]
        public void ChangeAttributeMethod()
        {
            Document activeDoc = Autodesk.AutoCAD.ApplicationServices.Core.Application.DocumentManager.MdiActiveDocument;
            Editor ed = activeDoc.Editor;

            PromptStringOptions pso1 = new PromptStringOptions("\nAttribute tag name: ");
            pso1.AllowSpaces = true;
            PromptResult pr1 = ed.GetString(pso1);
            if (pr1.Status != PromptStatus.OK)
                return;
            String AttributeTagName = pr1.StringResult;

            PromptStringOptions pso2 = new PromptStringOptions("\nold value : ");
            pso2.AllowSpaces = true;
            PromptResult pr2 = ed.GetString(pso2);
            if (pr2.Status != PromptStatus.OK)
                return;
            String oldValue = pr2.StringResult;

            PromptStringOptions pso3 = new PromptStringOptions("\nnew value : ");
            pso3.AllowSpaces = true;
            PromptResult pr3 = ed.GetString(pso3);
            if (pr3.Status != PromptStatus.OK)
                return;
            String newValue = pr3.StringResult;

            ChangeAttributeValue(AttributeTagName, oldValue, newValue);
        }

        void ChangeAttributeValue(String AttributeTagName, String OldValue, String NewValue)
        {
            Document activeDoc = Autodesk.AutoCAD.ApplicationServices.Core.Application.DocumentManager.MdiActiveDocument;

            Database db = activeDoc.Database;

            using (Transaction tr = db.TransactionManager.StartTransaction())
            {
                BlockTable bt = tr.GetObject(db.BlockTableId, OpenMode.ForWrite) as BlockTable;

                foreach (ObjectId oid in bt)
                {
                    BlockTableRecord btr = tr.GetObject(oid, OpenMode.ForWrite) as BlockTableRecord;

                    if (!btr.IsLayout)
                    {
                        ObjectIdCollection brefIds = btr.GetBlockReferenceIds(false, false);
                        foreach (ObjectId brId in brefIds)
                        {
                            BlockReference bref = tr.GetObject(brId, OpenMode.ForRead) as BlockReference;

                            foreach (ObjectId arId in bref.AttributeCollection)
                            {
                                AttributeReference ar = tr.GetObject(arId, OpenMode.ForRead) as AttributeReference;
                                if (ar != null)
                                {
                                    if (ar.Tag.ToUpper().Equals(AttributeTagName.ToUpper()))
                                    {
                                        if (ar.TextString.ToUpper().Equals(OldValue))
                                        {
                                            ar.UpgradeOpen();
                                            ar.TextString = NewValue;
                                        }
                                    }
                                }
                            }
                        }
                    }
                }

                tr.Commit();
            }
        }
        #endregion

        #region Purge
        [CommandMethod("MyPurge")]
        public void MyPurgeMethod()
        {
            Document activeDoc = Autodesk.AutoCAD.ApplicationServices.Core.Application.DocumentManager.MdiActiveDocument;
            Database db = activeDoc.Database;
            using (Transaction Tx = db.TransactionManager.StartTransaction())
            {
                BlockTable table = Tx.GetObject(db.BlockTableId,
                OpenMode.ForRead) as BlockTable;
                ObjectIdCollection blockIds = new ObjectIdCollection();
                do
                {
                    blockIds.Clear();
                    foreach (ObjectId id in table)
                        blockIds.Add(id);
                    db.Purge(blockIds);
                    foreach (ObjectId id in blockIds)
                    {
                        DBObject obj = Tx.GetObject(id, OpenMode.ForWrite);
                        obj.Erase();
                    }
                } while (blockIds.Count != 0);
                Tx.Commit();
            }
        }
        #endregion
    }
}