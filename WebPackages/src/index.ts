import {
    SigningCosmWasmClient
} from "@cosmjs/cosmwasm-stargate";
import { Window as KeplrWindow, ChainInfo } from "@keplr-wallet/types";
import { DesmosClient } from "@desmoslabs/sdk-core";

declare global {
    interface Window extends KeplrWindow {
        connectKeplr: (chainId: string) => Promise<string | null>,
        desmosClient: DesmosClient | undefined,
        initializeDesmosClient: (url: string) => void,
    }
}

window.connectKeplr = async function (chainId: string): Promise<string | null> {
    if (!window.keplr) {
        return null;
    } else {
        // Enabling before using the Keplr is recommended.
        // This method will ask the user whether to allow access if they haven't visited this website.
        // Also, it will request that the user unlock the wallet if the wallet is locked.
        await window.keplr.enable(chainId);

        const offlineSigner = await window.keplr.getOfflineSigner(chainId);
        const accounts = await offlineSigner.getAccounts();

        return accounts[0].address;
    }
}

window.initializeDesmosClient = async function (url: string) {
    if (window.desmosClient === undefined) {
        window.desmosClient = DesmosClient.withoutSigner(url);
        await window.desmosClient.connect();
    }
}