import {
    SigningCosmWasmClient
} from "@cosmjs/cosmwasm-stargate";
import { Window as KeplrWindow } from "@keplr-wallet/types";

declare global {
    interface Window extends KeplrWindow {
        connectKeplrAsync: (chainId: string) => Promise<string | null>,
    }
}

window.connectKeplrAsync = async function (chainId: string): Promise<string | null> {
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