public class Gestor
{
    private ALVTree arbolAVL;

    public Gestor()
    {
        arbolAVL = new ALVTree();
    }

    public string mostarArbolPreOrden()
    {
        return arbol.mostrarArbolPreorden();
    }

    public string mostarArbolInOrden()
    {
        return arbol.mostarArbolInOrden();
    }

    public string mostarArbolPostOrden()
    {
        return arbol.mostarArbolPostOrden();
    }

    public bool verificarArbolVacio()
    {
        return arbol.verificarArbolVacio();
    }

    public bool insertarArbol(int valor)
    {
        return arbol.insertarElemento(valor);
    }
}